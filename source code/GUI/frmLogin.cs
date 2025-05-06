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
using timber_shop_manager.BUS;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmLogin : Form
    {
        #region Properties
        private readonly AccountBUS accountBUS = new AccountBUS();
        public frmLogin()
        {
            InitializeComponent();

            if (!string.IsNullOrEmpty(Properties.Settings.Default.Username))
                txtUsername.Text = Properties.Settings.Default.Username;

        }
        #endregion
        #region Support methods
        private void SaveUsername(string username)
        {
            Properties.Settings.Default.Username = username;
            Properties.Settings.Default.Save();
            txtPassword.Clear();
        }
        #endregion
        #region Load event

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.Username;

            if (Properties.Settings.Default.isFirstRun)
            {
                new frmConfig().ShowDialog();
            }
            Properties.Settings.Default.isFirstRun = false;
            Properties.Settings.Default.Save();
            txtPassword.UseSystemPasswordChar = true;
            pbVisible.Visible = true;
            pbInvisible.Visible = false;
            btnForgotPassword.Visible = false;

            lblPassError.Text = string.Empty;
            lblUserError.Text = string.Empty;
        }
        #endregion
        #region Button click event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var email = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            lblUserError.Text = string.Empty;
            lblPassError.Text = string.Empty;

            bool hasError = false;

            // Validate rỗng
            if (string.IsNullOrEmpty(email))
            {
                lblUserError.Text = "Vui lòng nhập tên đăng nhập.";
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                lblPassError.Text = "Vui lòng nhập mật khẩu.";
                return;
            }

            lblUserError.Text = lblPassError.Text = string.Empty;

            SaveUsername(email);

            // Gọi BUS để xác thực
            var employee = accountBUS.LoginAndGetEmployee(email, password);
            if (employee == null)
            {
                lblPassError.Text = "Tên đăng nhập hoặc mật khẩu không đúng, hoặc tài khoản bị khoá.";
                txtPassword.Clear();
                btnForgotPassword.Visible = true;
                return;
            }

            var frmMain = new frmMain(employee);
            this.Hide();    
            frmMain.ShowDialog();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmChangePW(this).ShowDialog();
        }
        private void btnConfig_Click(object sender, EventArgs e)
        {
            new frmConfig().ShowDialog();
        }
        private void pbVisible_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false; // Show the password
            pbVisible.Visible = false; // Hide the "visible" button
            pbInvisible.Visible = true; // Show the "invisible" button
        }
        private void pbInvisible_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true; // Hide the password
            pbVisible.Visible = true; // Show the "visible" button
            pbInvisible.Visible = false; // Hide the "invisible" button
        }
        #endregion
        #region Form closing event
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
