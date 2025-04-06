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

        private void frmLogin_Load(object sender, EventArgs e)
        {
            ResetForm();
            lblUserError.Text = string.Empty;
            lblPassError.Text = string.Empty;
        }

        private void ResetForm()
        {
            LoadAvatar("../../../assets/img/placehold-avatar.png");

            txtUsername.Text = Properties.Settings.Default.Username;
            txtPassword.Text = string.Empty;

            //lblUserError.Text = string.Empty;
            //lblPassError.Text = string.Empty;
        }

        private void LoadAvatar(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                picAvatar.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Không tìm thấy ảnh tại đường dẫn đã chỉ định.");
            }
        }

        private void SaveUsername(string username)
        {
            Properties.Settings.Default.Username = txtUsername.Text;
            Properties.Settings.Default.Save();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account account = new Account(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (!account.verifyUsername())
            {
                lblUserError.Text = "*Tên đăng nhập không đúng!";
                SaveUsername(txtUsername.Text);
                ResetForm();
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
    }
}
