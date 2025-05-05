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
using timber_shop_manager.DTO;
using timber_shop_manager.BUS;
using timber_shop_manager.Utils;

namespace timber_shop_manager
{
    public partial class frmFinancial : Form
    {
        private readonly FinancialBUS financialBUS = new();
        private DatabaseHelper dbHelper = new();
        private EmployeeDTO emp;
        private string id = "E003", name;
        public frmFinancial()
        {
            InitializeComponent();
        }

        public frmFinancial(EmployeeDTO emp) : this()
        {
            this.emp = emp;
            id = emp.Id;
            name = emp.Name;
            txtName.Text = emp.Name;
        }

        private void frmFinancialReport_Load(object sender, EventArgs e)
        {
            LoadFinancialSummary();
            LoadFinancialDetails();
        }

        private void LoadFinancialSummary()
        {
            var report = financialBUS.GetMonthlyReport(dtpTimeView.Value);
            txtTotalRevenue.Text = report.Revenue.ToString("N0");
            txtTotalExpenses.Text = report.Expenses.ToString("N0");
            txtPofit.Text = report.Profit.ToString("N0");
        }

        private void LoadFinancialDetails()
        {
            bool byDay = rdbDay.Checked;
            var table = financialBUS.GetFinancialDetails(dtpTimeView.Value, byDay);
            table.Columns.Add("LoiNhuan", typeof(decimal));
            foreach (DataRow row in table.Rows)
            {
                decimal thu = Convert.ToDecimal(row["TongThu"]);
                decimal chi = Convert.ToDecimal(row["TongChi"]);
                row["LoiNhuan"] = thu - chi;
            }

            dgv.DataSource = table;
            dgv.Columns[0].HeaderText = byDay ? "Ngày" : "Tháng";
            dgv.Columns["TongThu"].HeaderText = "Tổng thu";
            dgv.Columns["TongChi"].HeaderText = "Tổng chi";
            dgv.Columns["LoiNhuan"].HeaderText = "Lợi nhuận";

            UpdateChart(table);
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
                LoadFinancialDetails();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Chọn nơi lưu biên bản báo cáo tài chính",
                FileName = $"BaoCaoTaiChinh_Thang{dtpTimeView.Value:MM-yyyy}.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var reportBus = new FinancialReportExport();
                var report = new FinancialReportDTO
                {
                    Revenue = Convert.ToDecimal(txtTotalRevenue.Text),
                    Expenses = Convert.ToDecimal(txtTotalExpenses.Text)
                };

                try
                {
                    reportBus.ExportFinancialReport(
                        saveFileDialog.FileName,
                        report,
                        id,
                        name,
                        dtpTimeReport.Value,
                        dtpTimeView.Value.ToString("MM/yyyy")
                    );

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
            LoadFinancialSummary();
            LoadFinancialDetails();
        }
    }
}
