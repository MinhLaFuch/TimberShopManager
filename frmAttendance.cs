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

namespace timber_shop_manager
{
    public partial class frmAttendance : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
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
        #endregion
        #region Support Method
        private void LoadData()
        {
            string query = "SELECT * FROM Attendance WHERE EmployeeId = @employeeId";
            DataTable dt = dbHelper.ExecuteQuery(query, new SqlParameter("@employeeId", employeeId));
            if (dt.Rows.Count > 0)
            {
                txtEmployeeName.Text = dt.Rows[0]["EmployeeName"].ToString();
                txtWorkHour.Text = dt.Rows[0]["WorkHour"].ToString();
                txtSalary.Text = dt.Rows[0]["Salary"].ToString();
            }
        }
        #endregion
        #region Event
        #region Load
        private void frmWorkHour_Load(object sender, EventArgs e)
        {
            this.Text += this.EmployeeName;
        }
        #endregion
        #endregion
    }
}
