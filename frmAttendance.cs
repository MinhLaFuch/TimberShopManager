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
        private Account account;
        private string employeeId = "";
        private string employeeName = "";
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public frmAttendance()
        {
            InitializeComponent();
        }
        public frmAttendance(Account acc)
        {
            this.account = acc;
            // Get Employee from Account
            
            InitializeComponent();
        }
        #endregion
        #region Support Method
        private void loadForm()
        {
            this.Text = "Báo cáo chấm công của " + this.EmployeeName;
            dgv.DataSource = LoadData();
        }
        private DataTable LoadData()
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
        #endregion
        #region Event
        #region Load
        private void frmAttendance_Load(object sender, EventArgs e)
        {
            cbTimeStamp.SelectedIndex = 0;
            dtpFrom.Visible = dtpTo.Visible = false;
            loadForm();
        }
        #endregion
        #region Click
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadForm();
        }
        #endregion
        #region Change Value
        private void cbTimeStamp_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTimeStamp.SelectedItem.ToString() == "Ngày -> Ngày")
            {
                dtpFrom.Visible = dtpTo.Visible = true;
                dtpFrom.Value = DateTime.Now;
                dtpTo.Value = DateTime.Now;
            }
            else
            {
                dtpFrom.Visible = dtpTo.Visible = false;
            }
            loadForm();
        }
        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            loadForm();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            loadForm();
        }
        #endregion
        #endregion
    }
}
