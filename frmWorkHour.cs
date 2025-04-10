using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timber_shop_manager
{
    public partial class frmWorkHour : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private string employeeId = "";
        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
        }
        public frmWorkHour()
        {
            InitializeComponent();
        }
        #endregion
        private void frmWorkHour_Load(object sender, EventArgs e)
        {
            
        }
    }
}
