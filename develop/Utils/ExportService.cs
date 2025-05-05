using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Font = iTextSharp.text.Font;
using System.Diagnostics;
using Rectangle = iTextSharp.text.Rectangle;

namespace timber_shop_manager.Utils
{
    public static class ExportService
    {
        public static void ExportSalaryReportToPdf(DataTable data, string filePath, string reportDate, string reportMonthYear, string accountantId, string accountantName)
        {
            if (data.Rows.Count == 0)
                throw new Exception("Không có dữ liệu để xuất.");

            // Font tiếng Việt
            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
            BaseFont baseFont = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font titleFont = new Font(baseFont, 16, Font.BOLD, new BaseColor(40, 40, 40));
            Font metaFont = new Font(baseFont, 10, Font.NORMAL, new BaseColor(60, 60, 60));
            Font headerFont = new Font(baseFont, 11, Font.BOLD, BaseColor.BLACK);
            Font cellFont = new Font(baseFont, 10, Font.NORMAL, BaseColor.DARK_GRAY);

            PdfPTable table = new PdfPTable(data.Columns.Count)
            {
                WidthPercentage = 100,
                HorizontalAlignment = Element.ALIGN_LEFT,
                SpacingBefore = 10f,
                SpacingAfter = 10f
            };
            table.DefaultCell.Border = Rectangle.NO_BORDER;

            // Tiêu đề báo cáo
            table.AddCell(CreateMergedCell($"BÁO CÁO LƯƠNG THÁNG {reportMonthYear.ToUpper()}", titleFont, Element.ALIGN_CENTER, data.Columns.Count));
            table.AddCell(CreateEmptyRow(data.Columns.Count));

            // Thông tin báo cáo
            table.AddCell(CreateMergedCell($"Ngày lập báo cáo: {reportDate}", metaFont, Element.ALIGN_LEFT, data.Columns.Count));
            table.AddCell(CreateMergedCell($"Mã nhân viên kế toán: {accountantId}", metaFont, Element.ALIGN_LEFT, data.Columns.Count));
            table.AddCell(CreateMergedCell($"Tên nhân viên kế toán: {accountantName}", metaFont, Element.ALIGN_LEFT, data.Columns.Count));
            table.AddCell(CreateEmptyRow(data.Columns.Count));

            // Tiêu đề cột
            foreach (DataColumn column in data.Columns)
            {
                PdfPCell headerCell = new PdfPCell(new Phrase(column.ColumnName, headerFont))
                {
                    BackgroundColor = new BaseColor(235, 235, 235),
                    BorderWidth = 0.5f,
                    Padding = 5,
                    HorizontalAlignment = Element.ALIGN_CENTER
                };
                table.AddCell(headerCell);
            }

            // Dữ liệu
            foreach (DataRow row in data.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(item.ToString(), cellFont))
                    {
                        BorderWidth = 0.25f,
                        Padding = 5,
                        HorizontalAlignment = Element.ALIGN_CENTER
                    };
                    table.AddCell(cell);
                }
            }

            // Ký tên
            table.AddCell(CreateEmptyRow(data.Columns.Count));
            table.AddCell(CreateMergedCell("Ký tên nhân viên kế toán", metaFont, Element.ALIGN_RIGHT, data.Columns.Count));

            // Xuất file PDF
            using (FileStream stream = new FileStream(filePath, FileMode.Create))
            {
                Document document = new Document(PageSize.A4, 36, 36, 36, 36);
                PdfWriter.GetInstance(document, stream);
                document.Open();
                document.Add(table);
                document.Close();
            }

            // Mở file sau khi xuất
            Process.Start(new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            });
        }

        // Tạo ô gộp dòng
        private static PdfPCell CreateMergedCell(string text, Font font, int alignment, int colspan)
        {
            return new PdfPCell(new Phrase(text, font))
            {
                Colspan = colspan,
                HorizontalAlignment = alignment,
                Border = Rectangle.NO_BORDER,
                PaddingBottom = 5
            };
        }

        // Tạo khoảng trắng
        private static PdfPCell CreateEmptyRow(int colspan)
        {
            return new PdfPCell(new Phrase(" "))
            {
                Colspan = colspan,
                Border = Rectangle.NO_BORDER,
                FixedHeight = 10f
            };
        }
    }
}
