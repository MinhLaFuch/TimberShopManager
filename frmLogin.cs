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
        #region Properties
        public frmLogin()
        {
            InitializeComponent();

            if (Properties.Settings.Default.Username != null)
            {
                txtUsername.Text = Properties.Settings.Default.Username;
            }

        }
        #endregion
        #region Support Methods
        private void SaveUsername(string username)
        {
            Properties.Settings.Default.Username = txtUsername.Text;
            Properties.Settings.Default.Save();
        }
        private void LoadForm()
        {
            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = string.Empty;

            //lblUserError.Text = string.Empty;
            //lblPassError.Text = string.Empty;
        }
        #endregion
        #region Events
        #region Load
        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Load form
            LoadForm();

            // Changing the panel style
            ApplyRoundedBorderToPanel();

            // Set the error text
            lblUserError.Text = string.Empty;
            lblPassError.Text = string.Empty;

            // Hide Forgor Password button
            btnForgotPassword.Visible = false;
        }
        #endregion
        #region Click
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account account = new Account(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (!account.verifyUsername())
            {
                lblUserError.Text = "*Tên đăng nhập không đúng!";
                SaveUsername(txtUsername.Text);
                LoadForm();
            }
            else if (!account.verifyPassword())
            {
                lblPassError.Text = "*Mật khẩu không đúng";
                SaveUsername(txtUsername.Text);
                lblUserError.Text = string.Empty;
                txtPassword.Text = string.Empty;
                btnForgotPassword.Visible = true;
            }
            else
            {
                SaveUsername(txtUsername.Text);

                frmMain frmMain = new frmMain(account);
                this.Hide();
                frmMain.ShowDialog();
            }

        }
        #endregion
        #region Paint
        #endregion
        #endregion
    }
}
