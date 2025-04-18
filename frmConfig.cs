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
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void chbWindowAuthetication_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isWindowAuthentication = chkWindowAuthetication.Checked;


            Properties.Settings.Default.Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            chkWindowAuthetication.Checked = Properties.Settings.Default.isWindowAuthentication;
            if (chkWindowAuthetication.Checked)
            {
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DBServer = txtServer.Text;
            Properties.Settings.Default.isWindowAuthentication = chkWindowAuthetication.Checked;
            Properties.Settings.Default.DBUsername = txtUsername.Text;
            Properties.Settings.Default.DBPassword = txtPassword.Text;
            Properties.Settings.Default.isRemenberPassword = chkRememberPassword.Checked;

            Properties.Settings.Default.Save();
        }
    }
}
