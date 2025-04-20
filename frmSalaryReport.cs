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
            SetDefaultDateForDtpReportFor();
            dgv.DataSource = LoadSalaryReport();

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

        private DataTable LoadSalaryReport()
        {
            DateTime reportDate = dtpReportFor.Value;
            int month = reportDate.Month;
            int year = reportDate.Year;

            // Truy vấn SQL để lấy dữ liệu, tính ngày công chỉ khi có đủ 2 lần chấm công trong một ngày
            string query = @"
SELECT 
    e.Id AS [Mã nhân viên], 
    e.Name AS [Tên nhân viên],
    COUNT(DISTINCT CAST(a.Date AS DATE)) AS [Tổng ngày công],  
    SUM(CASE WHEN a.Review LIKE '%muộn%' THEN 1 ELSE 0 END) AS [Số ngày trễ],
    (DATEDIFF(DAY, 
        CAST(@year AS VARCHAR) + '-' + CAST(@month AS VARCHAR) + '-01', 
        EOMONTH(CAST(@year AS VARCHAR) + '-' + CAST(@month AS VARCHAR) + '-01')) + 1 
    - COUNT(DISTINCT CAST(a.Date AS DATE))) AS [Số ngày vắng],  
    (COUNT(DISTINCT CAST(a.Date AS DATE)) * e.Salary) AS [Tổng lương]  
FROM Employee e
LEFT JOIN Attendance a ON e.Id = a.Id 
AND MONTH(a.Date) = @month 
AND YEAR(a.Date) = @year
GROUP BY e.Id, e.Name, e.Salary


";

            var data = dbHelper.ExecuteQuery(query,
                new SqlParameter("@month", month),
                new SqlParameter("@year", year));

            return data;
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
            DataTable dgv = LoadSalaryReport();

            string reportDate = DateTime.Now.ToString("dd/MM/yyyy");
            string reportMonthYear = dtpReportFor.Value.ToString("MM/yyyy");
            string accountantId = txtAccountantId.Text;
            string accountantName = txtAccountantName.Text;

            // Gọi hàm ExportToPdf
            ExportToPdf(dgv, reportDate, reportMonthYear, accountantId, accountantName);
        }

        private void ExportToPdf(DataTable dgv, string reportDate, string reportMonthYear, string accountantId, string accountantName)
        {
            if (dgv.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = $"SalaryReport{DateTime.Now.ToString("yyyyMMddss")}";
                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Không thể ghi dữ liệu vào đĩa: " + ex.Message);
                        }
                    }

                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgv.Columns.Count);
                            pTable.DefaultCell.Padding = 5;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Sử dụng font hỗ trợ tiếng Việt (Ví dụ: VnTime)
                            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
                            //iTextSharp.text.Font textFont = new iTextSharp.text.Font(bf, 12);
                            //iTextSharp.text.Font boldVietnameseFont = new iTextSharp.text.Font(bf, 14, iTextSharp.text.Font.BOLD); // Font in đậm

                            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 14, 1);
                            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bf, 11, 1);
                            iTextSharp.text.Font textFont = new iTextSharp.text.Font(bf, 11, 0);


                            // Tiêu đề báo cáo với màu sắc và font chữ đẹp hơn
                            pTable.AddCell(new PdfPCell(new Phrase("CÔNG TY ABC", titleFont)) { Colspan = dgv.Columns.Count, HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase("BÁO CÁO LƯƠNG THÁNG " + reportMonthYear.ToUpper(), titleFont)) { Colspan = dgv.Columns.Count, HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase(" ")) { Colspan = dgv.Columns.Count, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase("Ngày lập báo cáo: " + reportDate, textFont)) { Colspan = dgv.Columns.Count, HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase("Mã nhân viên kế toán: " + accountantId, textFont)) { Colspan = dgv.Columns.Count, HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase("Tên nhân viên kế toán: " + accountantName, textFont)) { Colspan = dgv.Columns.Count, HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });

                            // Thêm một dòng khoảng cách để báo cáo trông thoáng hơn
                            pTable.AddCell(new PdfPCell(new Phrase(" ")) { Colspan = dgv.Columns.Count, Border = 0 });


                            // Thêm tiêu đề cột từ DataTable
                            foreach (DataColumn col in dgv.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.ColumnName, headerFont));
                                //pCell.BackgroundColor = BaseColor.GRAY; // Màu nền cho tiêu đề cột
                                pTable.AddCell(pCell);
                            }

                            // Thêm dữ liệu từ DataTable vào bảng PDF
                            foreach (DataRow row in dgv.Rows)
                            {
                                foreach (var cell in row.ItemArray)
                                {
                                    pTable.AddCell(new Phrase(cell.ToString(), textFont));
                                }
                            }

                            // Thêm khu vực ký tên nhân viên kế toán căn bên phải
                            //PdfPCell signCell = new PdfPCell(new Phrase("Ký tên nhân viên kế toán:", textFont)) { Colspan = dgv.Columns.Count - 1, Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT };
                            //pTable.AddCell(signCell);
                            //PdfPCell signLineCell = new PdfPCell(new Phrase("__________________________", textFont)) { Colspan = 1, Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT };
                            //pTable.AddCell(signLineCell);
                            pTable.AddCell(new PdfPCell(new Phrase(" ")) { Colspan = dgv.Columns.Count, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase("Ký tên nhân viên kế toán", textFont)) { Colspan = dgv.Columns.Count, HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });

                            // Tạo tệp PDF và lưu vào file
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }

                            MessageBox.Show("Dữ liệu đã được xuất thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xuất dữ liệu: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu", "Thông báo");
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra nếu người dùng không click vào tiêu đề cột
            {
                btnViewAttend.Enabled = true;
                // Lấy dòng được chọn
                DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];

                // Lấy thông tin từ các cột
                string employeeId = selectedRow.Cells["Mã nhân viên"].Value.ToString();
                string employeeName = selectedRow.Cells["Tên nhân viên"].Value.ToString();
                int totalAttendDays = Convert.ToInt32(selectedRow.Cells["Tổng ngày công"].Value);
                int absentDays = Convert.ToInt32(selectedRow.Cells["Số ngày vắng"].Value);
                int lateDays = Convert.ToInt32(selectedRow.Cells["Số ngày trễ"].Value);
                long totalSalary = Convert.ToInt64(selectedRow.Cells["Tổng lương"].Value);

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
