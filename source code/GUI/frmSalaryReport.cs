using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;
using timber_shop_manager.DTO;
using timber_shop_manager.BUS;
using timber_shop_manager.Utils;

namespace timber_shop_manager
{
    public partial class frmSalaryReport : Form
    {
        private readonly EmployeeDTO emp;
        private readonly EmployeeBUS empBUS = new();
        private EmployeeSalaryDTO dto = null;
        private SalaryReportBUS salaryReportBUS = new SalaryReportBUS();

        public frmSalaryReport()
        {
            InitializeComponent();
        }
        public frmSalaryReport(EmployeeDTO emp) : this()
        {
            this.emp = emp;
        }

        private void frmSalaryReport_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;
            DateTime firstDayOfCurrentMonth = new DateTime(today.Year, today.Month, 1);
            DateTime lastDayOfPreviousMonth = firstDayOfCurrentMonth.AddDays(-1);

            dtpReportFor.MaxDate = lastDayOfPreviousMonth;

            dtpReportFor.Value = lastDayOfPreviousMonth;
            btnViewAttend.Enabled = false;
        }

        private DataTable LoadSalaryReport()
        {
            return salaryReportBUS.GetSalaryReportDataTable(dtpReportFor.Value);
        }


        private void btnViewAttend_Click(object sender, EventArgs e)
        {
            frmAttendance frmAttendance = new frmAttendance(empBUS.GetEmployeeById(dto.EmployeeId), true);
            frmAttendance.ShowDialog();
        }

        private void dtpReportFor_ValueChanged(object sender, EventArgs e)
        {
            // Ép giá trị luôn là ngày 1 của tháng được chọn
            DateTime selected = dtpReportFor.Value;
            DateTime firstDayOfMonth = new DateTime(selected.Year, selected.Month, 1);
            if (selected != firstDayOfMonth)
            {
                dtpReportFor.Value = firstDayOfMonth;
                return; // Chờ sự kiện được kích hoạt lại với giá trị đúng
            }

            // Kiểm tra nếu tháng được chọn là tháng hiện tại hoặc tương lai thì thông báo và đặt lại về tháng trước
            DateTime now = DateTime.Today;
            if ((firstDayOfMonth.Year > now.Year) ||
               (firstDayOfMonth.Year == now.Year && firstDayOfMonth.Month >= now.Month))
            {
                MessageBox.Show("Chỉ được xem các tháng trước tháng hiện tại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DateTime previousMonth = new DateTime(now.Year, now.Month, 1).AddMonths(-1);
                dtpReportFor.Value = previousMonth;
                return;
            }

            // Cập nhật DataGridView dựa trên giá trị đã ép
            dgv.DataSource = salaryReportBUS.GetSalaryReportDataTable(firstDayOfMonth);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            DataTable reportData = LoadSalaryReport();

            SaveFileDialog save = new SaveFileDialog
            {
                Filter = "PDF (*.pdf)|*.pdf",
                FileName = $"SalaryReport{DateTime.Now:yyyyMMddss}"
            };

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportService.ExportSalaryReportToPdf(
                        reportData,
                        save.FileName,
                        DateTime.Now.ToString("dd/MM/yyyy"),
                        dtpReportFor.Value.ToString("MM/yyyy"),
                        txtAccountantId.Text,
                        txtAccountantName.Text
                    );

                    MessageBox.Show("Dữ liệu đã được xuất thành công", "Thông báo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất dữ liệu: " + ex.Message);
                }
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnViewAttend.Enabled = true;
                btnViewAttend.Enabled = true;
                var row = dgv.Rows[e.RowIndex];
                dto = new EmployeeSalaryDTO
                {
                    EmployeeId = row.Cells["Mã nhân viên"].Value.ToString(),
                    EmployeeName = row.Cells["Tên nhân viên"].Value.ToString(),
                    TotalAttendDays = Convert.ToInt32(row.Cells["Tổng ngày công"].Value),
                    LateDays = Convert.ToInt32(row.Cells["Số ngày trễ"].Value),
                    AbsentDays = Convert.ToInt32(row.Cells["Số ngày vắng"].Value),
                    TotalSalary = Convert.ToInt64(row.Cells["Tổng lương"].Value)
                };

                txtEmployeeId.Text = dto.EmployeeId;
                txtEmployeeName.Text = dto.EmployeeName;
                txtAttendDay.Text = dto.TotalAttendDays.ToString();
                txtAbsentDay.Text = dto.AbsentDays.ToString();
                txtLateDay.Text = dto.LateDays.ToString();
                txtSalary.Text = dto.TotalSalary.ToString();

                pnEmployeeInfo.Visible = true;
            } else
            {
                btnViewAttend.Enabled = false;
            }
        }
    }
}
