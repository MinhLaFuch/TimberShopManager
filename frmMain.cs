using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmMain : Form
    {
        private Account account;
        public frmMain(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCategory frmCategory = new frmCategory();
            frmCategory.ShowDialog();
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            frmSale frmSale = new frmSale();
            frmSale.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadAvatar("../../../assets/img/placehold-avatar.png");

            lblUsername.Text = account.Username;
            lblRole.Text = Employee.ConverRole(account.verifyPermission());
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
