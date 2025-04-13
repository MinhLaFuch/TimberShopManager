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
        private GraphicsPath GetRoundedRectPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90); // Top-left corner
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90); // Top-right
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90); // Bottom-right
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90); // Bottom-left
            path.CloseFigure();

            return path;
        }
        #endregion
        #region Events
        #region Load
        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Load form
            LoadForm();

            // Changing the panel style
            int radius = 25;
            Rectangle rect = new Rectangle(0, 0, pnLogin.Width, pnLogin.Height);
            pnLogin.Region = new Region(GetRoundedRectPath(rect, radius));

            // Set the error text
            lblUserError.Text = string.Empty;
            lblPassError.Text = string.Empty;
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
        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;
            using (GraphicsPath path = GetRoundedRectPath(pnLogin.ClientRectangle, radius))
            using (Pen pen = new Pen(Color.DarkGreen, 2)) // Change color/size here
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }

        #endregion
        #endregion
    }
}
