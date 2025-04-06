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
            LoadAvatar("../../../assets/img/placehold-avatar.png");
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain frmMain = new frmMain();
            frmMain.ShowDialog();
            this.Show();
        }
    }
}
