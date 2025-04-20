using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmAttendance : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private Account account = null;

        public frmAttendance()
        {
            InitializeComponent();
        }
        // Will not work unless change OOP
        public frmAttendance(Account acc) : this()
        {
            this.account = acc;
        }

        private void loadForm()
        {
            cbTimeStamp.SelectedIndex = 0;
            dtpFrom.Visible = dtpTo.Visible = false;
            dgv.DataSource = loadData();
        }
        private DataTable loadData()
        {
            DataTable dt = new DataTable();
            if (dtpFrom.Visible && dtpTo.Visible)
            {
                string query = "SELECT * FROM Attendance WHERE EmployeeId = @employeeId AND DATE BETWEEN @from AND @to";
                dt = dbHelper.ExecuteQuery(query, new SqlParameter("@employeeId", employeeId),
                                                  new SqlParameter("@from", dtpFrom.Value.Date),
                                                  new SqlParameter("@to", dtpTo.Value.Date));
            }
            else if (String.IsNullOrEmpty(cbTimeStamp.Text))
            {
                if (cbTimeStamp.SelectedItem.ToString() == "Ngày")
                {
                    string query = "SELECT * FROM Attendance WHERE EmployeeId = @employeeId AND DATE = @date";
                    dt = dbHelper.ExecuteQuery(query, new SqlParameter("@employeeId", employeeId),
                                                      new SqlParameter("@date", DateTime.Now.Date));
                }
                else if (cbTimeStamp.SelectedItem.ToString() == "Tuần")
                {
                    string query = "SELECT * FROM Attendance WHERE EmployeeId = @employeeId AND DATE >= DATEADD(WEEK, DATEDIFF(WEEK, 0, GETDATE()), 0)";
                    dt = dbHelper.ExecuteQuery(query, new SqlParameter("@employeeId", employeeId));
                }
                else if (cbTimeStamp.SelectedItem.ToString() == "Tháng")
                {
                    string query = "SELECT * FROM Attendance WHERE EmployeeId = @employeeId AND DATE >= DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0)";
                    dt = dbHelper.ExecuteQuery(query, new SqlParameter("@employeeId", employeeId));
                }
                else if (cbTimeStamp.SelectedItem.ToString() == "Quý")
                {
                    string query = "SELECT * FROM Attendance WHERE EmployeeId = @employeeId AND DATE >= DATEADD(QUARTER, DATEDIFF(QUARTER, 0, GETDATE()), 0)";
                    dt = dbHelper.ExecuteQuery(query, new SqlParameter("@employeeId", employeeId));
                }
                else if (cbTimeStamp.SelectedItem.ToString() == "Năm")
                {
                    string query = "SELECT * FROM Attendance WHERE EmployeeId = @employeeId AND DATE >= DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0)";
                    dt = dbHelper.ExecuteQuery(query, new SqlParameter("@employeeId", employeeId));
                }
            }
            else
            {
                string query = "SELECT * FROM Attendance WHERE EmployeeId = @employeeId";
                dt = dbHelper.ExecuteQuery(query, new SqlParameter("@employeeId", employeeId));
            }
            return dt;
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadForm();
        }
        private void btnAttend_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            string review = String.Empty;

            // Determine attendance status
            if (currentTime.Hour >= 7 && currentTime.Hour < 9)
            {
                lbAttendStatus.Text = "You are on time.";
                review = "On time";
            }
            else if (currentTime.Hour >= 9)
            {
                lbAttendStatus.Text = "You are late.";
                review = "Late";
            }

            // Update attendance in the database
            string query = "INSERT INTO Attendance (EmployeeId, Date, Time, Review) VALUES (@employeeId, @date, @time, @review)";
            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@employeeId", employeeId),
                new SqlParameter("@date", currentTime.Date),
                new SqlParameter("@time", currentTime.TimeOfDay),
                new SqlParameter("@review", review));
        }

        private void realTimeClock_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            lbHour.Text = currentTime.ToString("HH:mm:ss"); // Display real-time clock

            // Disable or enable btnAttend based on time
            if (currentTime.Hour >= 17 || currentTime.Hour < 7 || account == null)
            {
                btnAttend.Enabled = false;
            }
            else
            {
                btnAttend.Enabled = true;
            }
        }

    }
}
