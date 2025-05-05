using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using timber_shop_manager.DAL;
using timber_shop_manager.DTO;
using Font = iTextSharp.text.Font;

namespace timber_shop_manager.BUS
{
    public class SaleBUS
    {
        private readonly SaleDAL saleDAL = new();

        public string GenerateNextInvoiceId()
        {
            string lastId = saleDAL.GetLastInvoiceId();
            return Program.GenerateNextCode(lastId, SaleInvoiceDTO.PREFIX, SaleInvoiceDTO.CODE_LENGTH);
        }

        public void CreateInvoice(SaleInvoiceDTO invoice, List<SaleDetailDTO> details, string voucherId = null)
        {
            //saleDAL.EnsureSaleAgentExists(invoice.EmployeeId); // ensure FK passes
            saleDAL.SaveInvoice(invoice);

            foreach (var detail in details)
            {
                saleDAL.SaveSaleDetail(detail);
            }

            if (!string.IsNullOrWhiteSpace(voucherId))
            {
                saleDAL.SaveAppliedVoucher(invoice.Id, voucherId);
            }
        }


        public DataTable LoadAllInvoices()
        {
            return saleDAL.GetAllInvoices(); // This assumes SaleDAL has GetAllInvoices
        }

        public void PrintInvoice(
            SaleInvoiceDTO invoice,
            List<SaleDetailDTO> details,
            decimal totalBeforeDiscount,
            string voucherCode,
            decimal discountValue,
            decimal totalAfterDiscount)
        {
            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = $"HoaDon_{DateTime.Now:yyyyMMddHHmmss}"
            };

            if (save.ShowDialog() != DialogResult.OK)
                return;

            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            var titleFont = new Font(bf, 16, Font.BOLD);
            var sectionFont = new Font(bf, 12, Font.BOLD);
            var normalFont = new Font(bf, 11);
            var smallFont = new Font(bf, 10, Font.ITALIC);

            Document doc = new Document(PageSize.A5, 20f, 20f, 20f, 20f);
            using var fs = new FileStream(save.FileName, FileMode.Create);
            PdfWriter.GetInstance(doc, fs);
            doc.Open();

            // 🧾 Title
            doc.Add(new Paragraph("HÓA ĐƠN BÁN HÀNG", titleFont) { Alignment = Element.ALIGN_CENTER });
            doc.Add(new Paragraph(" "));

            // 🔖 Basic Info
            var info = new[]
            {
        $"Mã hóa đơn: {invoice.Id}",
        $"Ngày thanh toán: {invoice.PaymentDate:dd/MM/yyyy}",
        $"Mã nhân viên: {invoice.EmployeeId}",
        $"SĐT khách hàng: {invoice.PhoneNumber}",
        $"Phương thức thanh toán: {invoice.PaymentMethod}"
    };
            foreach (string line in info)
                doc.Add(new Paragraph(line, normalFont));

            doc.Add(new Paragraph(" "));

            // 🧾 Table of items
            PdfPTable table = new PdfPTable(7) { WidthPercentage = 100 };
            string[] headers = { "Mã SP", "SL", "Đơn giá", "Thuế", "Tổng", "Bảo hành", "Tổng cộng" };
            foreach (string h in headers)
                table.AddCell(new Phrase(h, sectionFont));

            foreach (var item in details)
            {
                table.AddCell(new Phrase(item.ProductId, normalFont));
                table.AddCell(new Phrase(item.Quantity.ToString(), normalFont));
                table.AddCell(new Phrase(item.Price.ToString("#,##0"), normalFont));
                table.AddCell(new Phrase(item.Tax.ToString("P0"), normalFont));
                table.AddCell(new Phrase(item.Total.ToString("#,##0"), normalFont));
                table.AddCell(new Phrase(item.WarrantyEnd.ToString("dd/MM/yyyy"), normalFont));
                table.AddCell(new Phrase(item.Total.ToString("#,##0"), normalFont));
            }

            doc.Add(table);
            doc.Add(new Paragraph(" "));

            // 💵 Totals
            PdfPTable totals = new PdfPTable(2) { WidthPercentage = 100 };
            totals.AddCell(new Phrase("Tổng trước giảm:", normalFont));
            totals.AddCell(new Phrase(totalBeforeDiscount.ToString("#,##0") + " VND", normalFont));

            totals.AddCell(new Phrase("Mã giảm giá:", normalFont));
            totals.AddCell(new Phrase(string.IsNullOrEmpty(voucherCode) ? "-" : voucherCode, normalFont));

            totals.AddCell(new Phrase("Giảm giá:", normalFont));
            totals.AddCell(new Phrase(discountValue.ToString("#,##0") + " VND", normalFont));

            totals.AddCell(new Phrase("Tổng sau giảm:", sectionFont));
            totals.AddCell(new Phrase(totalAfterDiscount.ToString("#,##0") + " VND", sectionFont));

            doc.Add(totals);
            doc.Add(new Paragraph(" "));

            // ✍️ Signature
            doc.Add(new Paragraph("Chữ ký nhân viên", normalFont) { Alignment = Element.ALIGN_RIGHT });
            doc.Add(new Paragraph("\n\n", normalFont));
            doc.Add(new Paragraph("____________________", smallFont) { Alignment = Element.ALIGN_RIGHT });

            doc.Add(new Paragraph(" ", smallFont));
            doc.Add(new Paragraph("Cảm ơn quý khách đã mua hàng!", smallFont) { Alignment = Element.ALIGN_CENTER });

            doc.Close();
            //MessageBox.Show("Hóa đơn đã được in thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Hóa đơn đã được in thành công. Tệp sẽ được mở ngay bây giờ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // ✅ Automatically open the saved PDF using the default system viewer
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = save.FileName,
                    UseShellExecute = true // Required for .NET Core / .NET 5+ to open via OS
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở tệp PDF.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public List<InvoiceDetailDTO> GetInvoiceDetails(string invoiceId)
        {
            return saleDAL.GetInvoiceDetails(invoiceId);
        }


    }

}
