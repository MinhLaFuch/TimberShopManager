using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmSalaryReport : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private Account account;
        public frmSalaryReport()
        {
            InitializeComponent();
        }
        public frmSalaryReport(Account account) : this()
        {
            this.account = account;
        }
        #endregion
        #region Support methods

        #endregion
        #region Events
        #region Load
        private void frmSalaryReport_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region Click
        private void btnCreate_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAttend_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Text Change
        #endregion
        #endregion


    }
}
