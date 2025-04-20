using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmFinancial : Form
    {
        private DatabaseHelper dbHelper = new();
        private Account acc = null;
        public frmFinancial()
        {
            InitializeComponent();
        }

        public frmFinancial(Account acc)
        {
            this.acc = acc;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmFinancialReport_Load(object sender, EventArgs e)
        {
            LoadFinancialData();
            LoadFinancialDataForDisplay();
        }

        private void LoadFinancialDataForDisplay()
        {
            // Lấy tháng và năm từ dtpTimeView
            DateTime selectedDate = dtpTimeView.Value;
            int month = selectedDate.Month;
            int year = selectedDate.Year;

            string query = @"
        SELECT 
            ISNULL(SUM(CASE WHEN Type = 'Sale' THEN Total ELSE 0 END), 0) AS TongThu,
            ISNULL(SUM(CASE WHEN Type = 'Import' THEN Total ELSE 0 END), 0) AS TongChi
        FROM (
            SELECT PaymentDate, TotalCost AS Total, 'Sale' AS Type
            FROM SaleInvoice
            WHERE IsDeleted = 0 AND MONTH(PaymentDate) = @Month AND YEAR(PaymentDate) = @Year
            UNION ALL
            SELECT PaymentDate, TotalPrice AS Total, 'Import' AS Type
            FROM ImportInvoice
            WHERE IsDeleted = 0 AND MONTH(PaymentDate) = @Month AND YEAR(PaymentDate) = @Year
        ) AS Combined";

            // Tạo danh sách tham số và thêm tháng, năm vào tham số truy vấn
            List<SqlParameter> parameters = new();
            parameters.Add(new SqlParameter("@Month", month));
            parameters.Add(new SqlParameter("@Year", year));

            // Thực thi truy vấn để lấy dữ liệu từ cơ sở dữ liệu
            DataTable dt = dbHelper.ExecuteQuery(query, parameters.ToArray());

            // Lấy tổng thu và tổng chi từ kết quả truy vấn
            decimal totalRevenue = dt.Rows.Count > 0 ? Convert.ToDecimal(dt.Rows[0]["TongThu"]) : 0;
            decimal totalExpenses = dt.Rows.Count > 0 ? Convert.ToDecimal(dt.Rows[0]["TongChi"]) : 0;
            decimal profit = totalRevenue - totalExpenses;

            // Cập nhật giá trị vào các TextBox
            txtTotalRevenue.Text = totalRevenue.ToString("N0");  // Hiển thị dưới dạng số có phân cách hàng nghìn
            txtTotalExpenses.Text = totalExpenses.ToString("N0");
            txtPofit.Text = profit.ToString("N0");
        }


        private void LoadFinancialData()
        {
            DateTime selectedDate = dtpTimeView.Value;
            int month = selectedDate.Month;
            int year = selectedDate.Year;

            string query;
            List<SqlParameter> parameters = new();

            if (rdbDay.Checked)
            {
                // Thống kê theo từng ngày trong tháng
                query = @"
                    SELECT 
                        CAST(PaymentDate AS DATE) AS Ngay,
                        ISNULL(SUM(CASE WHEN Type = 'Sale' THEN Total ELSE 0 END), 0) AS TongThu,
                        ISNULL(SUM(CASE WHEN Type = 'Import' THEN Total ELSE 0 END), 0) AS TongChi
                    FROM (
                        SELECT PaymentDate, TotalCost AS Total, 'Sale' AS Type
                        FROM SaleInvoice
                        WHERE IsDeleted = 0 AND MONTH(PaymentDate) = @Month AND YEAR(PaymentDate) = @Year

                        UNION ALL

                        SELECT PaymentDate, TotalPrice AS Total, 'Import' AS Type
                        FROM ImportInvoice
                        WHERE IsDeleted = 0 AND MONTH(PaymentDate) = @Month AND YEAR(PaymentDate) = @Year
                    ) AS Combined
                    GROUP BY CAST(PaymentDate AS DATE)
                    ORDER BY Ngay";
                parameters.Add(new SqlParameter("@Month", month));
                parameters.Add(new SqlParameter("@Year", year));
            }
            else
            {
                // Thống kê theo từng tháng trong năm
                query = @"
                    SELECT 
                        MONTH(PaymentDate) AS Thang,
                        ISNULL(SUM(CASE WHEN Type = 'Sale' THEN Total ELSE 0 END), 0) AS TongThu,
                        ISNULL(SUM(CASE WHEN Type = 'Import' THEN Total ELSE 0 END), 0) AS TongChi
                    FROM (
                        SELECT PaymentDate, TotalCost AS Total, 'Sale' AS Type
                        FROM SaleInvoice
                        WHERE IsDeleted = 0 AND YEAR(PaymentDate) = @Year

                        UNION ALL

                        SELECT PaymentDate, TotalPrice AS Total, 'Import' AS Type
                        FROM ImportInvoice
                        WHERE IsDeleted = 0 AND YEAR(PaymentDate) = @Year
                    ) AS Combined
                    GROUP BY MONTH(PaymentDate)
                    ORDER BY Thang";
                parameters.Add(new SqlParameter("@Year", year));
            }

            // Lấy dữ liệu từ DB
            DataTable dt = dbHelper.ExecuteQuery(query, parameters.ToArray());

            // Thêm cột Lợi nhuận
            dt.Columns.Add("LoiNhuan", typeof(long));
            foreach (DataRow row in dt.Rows)
            {
                long thu = Convert.ToInt64(row["TongThu"]);
                long chi = Convert.ToInt64(row["TongChi"]);
                row["LoiNhuan"] = thu - chi;
            }

            dgv.DataSource = dt;

            // Hiển thị tổng cộng
            //txtTotalRevenue.Text = dt.AsEnumerable().Sum(r => r.Field<long>("TongThu")).ToString();
            //txtTotalExpenses.Text = dt.AsEnumerable().Sum(r => r.Field<long>("TongChi")).ToString();
            //txtPofit.Text = dt.AsEnumerable().Sum(r => r.Field<long>("LoiNhuan")).ToString();
            //dtpTimeReport.Value = DateTime.Today;

            // Cập nhật cột DataGridView
            if (rdbDay.Checked)
            {
                dgv.Columns["Ngay"].HeaderText = "Ngày";
            }
            else
            {
                dgv.Columns["Thang"].HeaderText = "Tháng";
            }
            dgv.Columns["TongThu"].HeaderText = "Tổng thu";
            dgv.Columns["TongChi"].HeaderText = "Tổng chi";
            dgv.Columns["LoiNhuan"].HeaderText = "Lợi nhuận";

            UpdateChart(dt);
        }

        private void UpdateChart(DataTable dt)
        {
            chart.Series.Clear();
            chart.ChartAreas[0].Area3DStyle.Enable3D = false;
            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart.ChartAreas[0].AxisY.LabelStyle.Format = "#,##0";

            var seriesThu = new Series("Tổng thu")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Green,
                IsValueShownAsLabel = true
            };
            var seriesChi = new Series("Tổng chi")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Red,
                IsValueShownAsLabel = true
            };
            var seriesLoiNhuan = new Series("Lợi nhuận")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue,
                IsValueShownAsLabel = true
            };

            seriesThu["PointWidth"] = "0.3";
            seriesChi["PointWidth"] = "0.3";
            seriesLoiNhuan["PointWidth"] = "0.3";

            chart.Series.Add(seriesThu);
            chart.Series.Add(seriesChi);
            chart.Series.Add(seriesLoiNhuan);

            chart.ChartAreas[0].AxisX.CustomLabels.Clear();

            int pointIndex = 0;
            foreach (DataRow row in dt.Rows)
            {
                string label = rdbDay.Checked
                    ? Convert.ToDateTime(row["Ngay"]).ToString("dd/MM")
                    : "Tháng " + Convert.ToInt32(row["Thang"]);

                double thu = Convert.ToDouble(row["TongThu"]);
                double chi = Convert.ToDouble(row["TongChi"]);
                double loiNhuan = Convert.ToDouble(row["LoiNhuan"]);

                // Add points to each series at same X-index
                seriesThu.Points.AddXY(pointIndex, thu);
                seriesChi.Points.AddXY(pointIndex, chi);
                seriesLoiNhuan.Points.AddXY(pointIndex, loiNhuan);

                // Add label at the middle of the 3 bars
                CustomLabel cl = new CustomLabel();
                cl.FromPosition = pointIndex - 0.5;
                cl.ToPosition = pointIndex + 0.5;
                cl.Text = label;
                chart.ChartAreas[0].AxisX.CustomLabels.Add(cl);

                pointIndex++;
            }

            chart.ChartAreas[0].AxisX.Title = rdbDay.Checked ? "Ngày" : "Tháng";
            chart.ChartAreas[0].AxisY.Title = "VNĐ";
            chart.ChartAreas[0].RecalculateAxesScale();
        }

        private void rdb_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                LoadFinancialData();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string maNV = "KT001"; 
            string tenNV = "Bui Ngoc Quy";
            DateTime ngayLap = dtpTimeReport.Value; 
            decimal tongThu = Convert.ToDecimal(txtTotalRevenue.Text);
            decimal tongChi = Convert.ToDecimal(txtTotalExpenses.Text);
            decimal loiNhuan = tongThu - tongChi; 
            string thangBaoCao = dtpTimeView.Value.ToString("MM/yyyy");

            ExportFinancialReportWithSaveDialog(maNV, tenNV, ngayLap, tongThu, tongChi, loiNhuan, thangBaoCao);
        }

        public void ExportFinancialReportWithSaveDialog(string maNV, string tenNV, DateTime ngayLap,
                                                 decimal tongThu, decimal tongChi, decimal loiNhuan,
                                                 string thangBaoCao)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Chọn nơi lưu biên bản báo cáo tài chính";
            saveFileDialog.FileName = $"BaoCaoTaiChinh_Thang{thangBaoCao.Replace("/", "-")}.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                try
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }

                    Document document = new Document(PageSize.A5, 20f, 20f, 20f, 20f);
                    PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                    document.Open();

                    // Font hỗ trợ tiếng Việt
                    string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                    BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                    iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 14, 1);
                    iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bf, 11, 1);
                    iTextSharp.text.Font textFont = new iTextSharp.text.Font(bf, 11, 0);

                    // Tiêu đề
                    Paragraph title = new Paragraph($"BIÊN BẢN BÁO CÁO TÀI CHÍNH THÁNG {thangBaoCao.ToUpper()}", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    title.SpacingAfter = 15f;
                    document.Add(title);

                    // Thông tin nhân viên
                    document.Add(new Paragraph($"1. Mã nhân viên kế toán: {maNV}", textFont));
                    document.Add(new Paragraph($"2. Họ và tên nhân viên kế toán: {tenNV}", textFont));
                    document.Add(new Paragraph($"3. Ngày lập báo cáo: {ngayLap:dd/MM/yyyy}", textFont));
                    document.Add(new Paragraph(" ", textFont));

                    // Bảng tài chính
                    PdfPTable table = new PdfPTable(2);
                    table.WidthPercentage = 100;
                    table.SpacingBefore = 10f;
                    table.SpacingAfter = 10f;
                    table.SetWidths(new float[] { 2f, 3f });

                    PdfPCell cell = new PdfPCell(new Phrase("4. THÔNG TIN TÀI CHÍNH", headerFont));
                    cell.Colspan = 2;
                    cell.HorizontalAlignment = Element.ALIGN_LEFT;
                    cell.BackgroundColor = new BaseColor(230, 230, 230);
                    cell.Padding = 5;
                    table.AddCell(cell);

                    table.AddCell(new Phrase("Tổng số tiền thu được", textFont));
                    table.AddCell(new Phrase(tongThu.ToString("N0") + " VNĐ", textFont));

                    table.AddCell(new Phrase("Tổng số tiền chi ra", textFont));
                    table.AddCell(new Phrase(tongChi.ToString("N0") + " VNĐ", textFont));

                    table.AddCell(new Phrase("Tổng lợi nhuận", textFont));
                    table.AddCell(new Phrase(loiNhuan.ToString("N0") + " VNĐ", textFont));

                    document.Add(table);

                    // Ghi chú
                    document.Add(new Paragraph("5. Ghi chú thêm (nếu có):", headerFont));
                    document.Add(new Paragraph(".........................................................................................", textFont));
                    document.Add(new Paragraph(".........................................................................................", textFont));
                    document.Add(new Paragraph(" ", textFont));

                    // Chữ ký
                    document.Add(new Paragraph("6. Chữ ký xác nhận", headerFont));
                    document.Add(new Paragraph("– Nhân viên lập báo cáo: ____________________", textFont));
                    document.Add(new Paragraph("– Quản lý cửa hàng xác nhận: ________________", textFont));
                    document.Add(new Paragraph(" ", textFont));

                    // Ghi chú cuối
                    Paragraph note = new Paragraph("📌 Ghi chú:\nLợi nhuận = Tổng số tiền thu được – Tổng số tiền chi ra.", textFont);
                    note.SpacingBefore = 10f;
                    document.Add(note);

                    document.Close();

                    MessageBox.Show("Xuất biên bản thành công!", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi tạo báo cáo: " + ex.Message, "Lỗi");
                }
            }
        }

        private void dtpTimeView_ValueChanged(object sender, EventArgs e)
        {
            LoadFinancialDataForDisplay();
        }
    }
}
