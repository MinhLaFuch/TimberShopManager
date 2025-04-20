using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmSalaryReport : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private Account account;
        private string accountantId = "E001", accountantName = "Bui Ngoc Quy";
        public frmSalaryReport()
        {
            InitializeComponent();
        }
        public frmSalaryReport(Account account) : this()
        {
            this.account = account;
        }

        private void frmSalaryReport_Load(object sender, EventArgs e)
        {
            txtAccountantId.Text = accountantId;
            txtAccountantName.Text = accountantName;
            SetupDataGridViewColumns();
            LoadSalaryReport();

            SetDefaultDateForDtpReportFor();
            DateTime firstDayOfMonth = new DateTime(dtpDateReport.Value.Year, dtpDateReport.Value.Month, 1).AddDays(-1);
            dtpReportFor.MaxDate = firstDayOfMonth;
            btnViewAttend.Enabled = false;
        }

        private void SetDefaultDateForDtpReportFor()
        {
            DateTime selectedDate = dtpDateReport.Value;

            DateTime firstDayOfPreviousMonth = new DateTime(selectedDate.Year, selectedDate.Month, 1).AddMonths(-1);

            dtpReportFor.Value = firstDayOfPreviousMonth;
        }

        private void SetupDataGridViewColumns()
        {
            // Cấu hình các cột của DataGridView
            dgv.Columns.Clear(); // Xóa các cột cũ nếu có

            dgv.Columns.Add("EmployeeId", "Mã Nhân Viên");
            dgv.Columns.Add("EmployeeName", "Tên Nhân Viên");
            dgv.Columns.Add("TotalAttendDays", "Tổng Ngày Công");
            dgv.Columns.Add("AbsentDays", "Ngày Vắng");
            dgv.Columns.Add("LateDays", "Ngày Trễ");
            dgv.Columns.Add("TotalSalary", "Tổng Lương");
        }

        private void LoadSalaryReport()
        {
            DateTime reportDate = dtpReportFor.Value;
            int month = reportDate.Month;
            int year = reportDate.Year;

            // Truy vấn SQL để lấy dữ liệu, tính ngày công chỉ khi có đủ 2 lần chấm công trong một ngày
            string query = @"
SELECT 
    e.Id AS EmployeeId, 
    e.Name AS EmployeeName,
    COUNT(DISTINCT CAST(a.Date AS DATE)) AS TotalAttendDays,  
    SUM(CASE WHEN a.Review LIKE '%muộn%' THEN 1 ELSE 0 END) AS LateDays,
    (DATEDIFF(DAY, 
        CAST(@year AS VARCHAR) + '-' + CAST(@month AS VARCHAR) + '-01', 
        EOMONTH(CAST(@year AS VARCHAR) + '-' + CAST(@month AS VARCHAR) + '-01')) + 1 
    - COUNT(DISTINCT CAST(a.Date AS DATE))) AS AbsentDays,  
    (COUNT(DISTINCT CAST(a.Date AS DATE)) * e.Salary) AS TotalSalary  
FROM Employee e
LEFT JOIN Attendance a ON e.Id = a.Id 
AND MONTH(a.Date) = @month 
AND YEAR(a.Date) = @year
GROUP BY e.Id, e.Name, e.Salary

";

            var data = dbHelper.ExecuteQuery(query,
                new SqlParameter("@month", month),
                new SqlParameter("@year", year));

            dgv.Rows.Clear(); // Xóa các dòng cũ trong DataGridView

            foreach (DataRow row in data.Rows)
            {
                string employeeId = row["EmployeeId"].ToString();
                string employeeName = row["EmployeeName"].ToString();
                int totalAttendDays = Convert.ToInt32(row["TotalAttendDays"]);
                int lateDays = Convert.ToInt32(row["LateDays"]);
                int absentDays = Convert.ToInt32(row["AbsentDays"]);
                long totalSalary = Convert.ToInt64(row["TotalSalary"]);  // Lấy tổng lương từ truy vấn

                // Thêm dữ liệu vào DataGridView
                dgv.Rows.Add(employeeId, employeeName, totalAttendDays, absentDays, lateDays, totalSalary);
            }

            // Tính tổng lương của tất cả nhân viên trong tháng
            //txtSalary.Text = data.AsEnumerable().Sum(row => Convert.ToInt64(row["TotalSalary"])).ToString();
        }

        private void btnViewAttend_Click(object sender, EventArgs e)
        {
            frmAttendance frmAttendance = new frmAttendance(txtEmployeeId.Text);
            frmAttendance.ShowDialog();
        }

        private void dtpReportFor_ValueChanged(object sender, EventArgs e)
        {
            LoadSalaryReport();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu người dùng không click vào tiêu đề cột
            {
                btnViewAttend.Enabled = true;
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];

                // Lấy thông tin từ các cột
                string employeeId = selectedRow.Cells["EmployeeId"].Value.ToString();
                string employeeName = selectedRow.Cells["EmployeeName"].Value.ToString();
                int totalAttendDays = Convert.ToInt32(selectedRow.Cells["TotalAttendDays"].Value);
                int absentDays = Convert.ToInt32(selectedRow.Cells["AbsentDays"].Value);
                int lateDays = Convert.ToInt32(selectedRow.Cells["LateDays"].Value);
                long totalSalary = Convert.ToInt64(selectedRow.Cells["TotalSalary"].Value);

                // Hiển thị thông tin lên pnEmployeeInfo (Panel chứa thông tin nhân viên)
                txtEmployeeId.Text = employeeId;
                txtEmployeeName.Text = employeeName;
                txtAttendDay.Text = totalAttendDays.ToString();
                txtAbsentDay.Text = absentDays.ToString();
                txtLateDay.Text = lateDays.ToString();
                txtSalary.Text = totalSalary.ToString();

                // Mở panel hiển thị thông tin (nếu cần)
                pnEmployeeInfo.Visible = true; // Hiển thị panel
            }
        }
    }
}
