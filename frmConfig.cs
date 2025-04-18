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

            pnlSQLAuthentication.Enabled = !chkWindowAuthetication.Checked;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            chkWindowAuthetication.Checked = Properties.Settings.Default.isWindowAuthentication;

            txtServer.Text = Properties.Settings.Default.DBServer;
            txtDatbaseName.Text = Properties.Settings.Default.DBName;

            pnlSQLAuthentication.Enabled = !chkWindowAuthetication.Checked;
            if (pnlSQLAuthentication.Enabled)
            {
                txtUsername.Text = Properties.Settings.Default.DBUsername;
                chkRememberPassword.Checked = Properties.Settings.Default.isRemenberPassword;
                if (chkRememberPassword.Checked)
                {
                    txtPassword.Text = Properties.Settings.Default.DBPassword;
                }
            }

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.DBServer = txtServer.Text;
            Properties.Settings.Default.isWindowAuthentication = chkWindowAuthetication.Checked;
            Properties.Settings.Default.DBUsername = txtUsername.Text;
            Properties.Settings.Default.DBPassword = txtPassword.Text;
            Properties.Settings.Default.isRemenberPassword = chkRememberPassword.Checked;
            Properties.Settings.Default.DBName = txtDatbaseName.Text;

            Properties.Settings.Default.Save();


            lblConnectStatus.Text = "Đang kiểm tra kết nối";
            lblConnectStatus.Visible = true;

            DatabaseHelper dbHelper = new DatabaseHelper();
            bool isConneted = dbHelper.isConnected();

            lblConnectStatus.ForeColor = isConneted ? Color.Green : Color.Red;
            lblConnectStatus.Text = isConneted ? "Kết nối thành công!" : "Không thể kết nối.";
        }
    }
}
