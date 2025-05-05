using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using timber_shop_manager.DTO;
using Font = iTextSharp.text.Font;
using System.Diagnostics;

namespace timber_shop_manager.Utils
{
    public class FinancialReportExport
    {
        public void ExportFinancialReport(string filePath, FinancialReportDTO report, string employeeId, string employeeName, DateTime reportDate, string monthText)
        {
            Document document = new Document(PageSize.A5, 20f, 20f, 20f, 20f);
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            var titleFont = new Font(bf, 14, 1);
            var headerFont = new Font(bf, 11, 1);
            var textFont = new Font(bf, 11, 0);

            Paragraph title = new Paragraph($"BIÊN BẢN BÁO CÁO TÀI CHÍNH THÁNG {monthText.ToUpper()}", titleFont)
            {
                Alignment = Element.ALIGN_CENTER,
                SpacingAfter = 15f
            };
            document.Add(title);

            document.Add(new Paragraph($"1. Mã nhân viên kế toán: {employeeId}", textFont));
            document.Add(new Paragraph($"2. Họ và tên nhân viên kế toán: {employeeName}", textFont));
            document.Add(new Paragraph($"3. Ngày lập báo cáo: {reportDate:dd/MM/yyyy}", textFont));
            document.Add(new Paragraph(" ", textFont));

            PdfPTable table = new PdfPTable(2) { WidthPercentage = 100, SpacingBefore = 10f, SpacingAfter = 10f };
            table.SetWidths(new float[] { 2f, 3f });

            PdfPCell cell = new PdfPCell(new Phrase("4. THÔNG TIN TÀI CHÍNH", headerFont))
            {
                Colspan = 2,
                HorizontalAlignment = Element.ALIGN_LEFT,
                BackgroundColor = new BaseColor(230, 230, 230),
                Padding = 5
            };
            table.AddCell(cell);

            table.AddCell(new Phrase("Tổng số tiền thu được", textFont));
            table.AddCell(new Phrase(report.Revenue.ToString("N0") + " VNĐ", textFont));
            table.AddCell(new Phrase("Tổng số tiền chi ra", textFont));
            table.AddCell(new Phrase(report.Expenses.ToString("N0") + " VNĐ", textFont));
            table.AddCell(new Phrase("Tổng lợi nhuận", textFont));
            table.AddCell(new Phrase(report.Profit.ToString("N0") + " VNĐ", textFont));

            document.Add(table);

            document.Add(new Paragraph("5. Ghi chú thêm (nếu có):", headerFont));
            document.Add(new Paragraph(".........................................................................................", textFont));
            document.Add(new Paragraph(".........................................................................................", textFont));
            document.Add(new Paragraph(" ", textFont));

            document.Add(new Paragraph("6. Chữ ký xác nhận", headerFont));
            document.Add(new Paragraph("– Nhân viên lập báo cáo: ____________________", textFont));
            document.Add(new Paragraph("– Quản lý cửa hàng xác nhận: ________________", textFont));

            Paragraph note = new Paragraph("📌 Ghi chú:\nLợi nhuận = Tổng số tiền thu được – Tổng số tiền chi ra.", textFont)
            {
                SpacingBefore = 10f
            };
            document.Add(note);

            document.Close();
            if (File.Exists(filePath))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
        }
    }
}
