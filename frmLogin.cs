using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Username != null)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
            }

        }
        private void SaveUsername(string username)
        {
            Properties.Settings.Default.Username = txtUsername.Text;
            Properties.Settings.Default.Save();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.Username;

            if (Properties.Settings.Default.isFirstRun)
            {
                frmConfig frmConfig = new frmConfig();
                frmConfig.ShowDialog();

                //Properties.Settings.Default.isFirstRun = false;
                //Properties.Settings.Default.Save();
            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account account = new Account(txtUsername.Text, txtPassword.Text);
            SaveUsername(txtUsername.Text);

            //if (!account.verifyUsername())
            //{
            //    lblUserError.Text = "Tên đăng nhập không đúng!";
            //}
            //else if (!account.verifyPassword())
            //{
            //    lblPassError.Text = "Mật khẩu không đúng";
            //    lblUserError.Text = string.Empty;
            //    txtPassword.Text = string.Empty;
            //}
            //else
            //{
            //    frmMain frmMain = new frmMain(account);
            //    this.Hide();
            //    frmMain.ShowDialog();
            //}
            // Add a case for locked account
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            frmChangePW frmChangePW = new frmChangePW();
            this.Hide();
            frmChangePW.ShowDialog();
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConfig frmConfig = new frmConfig();
            frmConfig.ShowDialog();
        }
    }
}
