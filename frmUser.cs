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
    public partial class frmUser : Form
    {
        #region Properties
        private Account account;
        public frmUser(Account acc)
        {
            this.account = acc;
            InitializeComponent();
        }
        #endregion
        #region Support Methods
        private void loadForm()
        {
            gbInfo.Enabled = false;
            
            loadInfo();
            btnVisibleEnabler(false);
        }
        private void btnVisibleEnabler(bool b)
        {
            pnInfoButton.Visible = b;
            pnFeatureButton.Visible = !b;
        }
        private void loadInfo()
        {
            //txtGmail.Text = account.Username + "@gmail.com";
            //txtPassword.Text = account.Password;
            
        }
        #endregion
        #region Events
        #region Load
        private void frmUser_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        #endregion
        #region Click
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadForm();
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            gbInfo.Enabled = true;
            txtName.Focus();
        }

        private void btnChangePW_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion

    }
}
