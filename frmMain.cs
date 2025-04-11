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
            frmManage frmCategory = new frmManage();
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

        private void mnuManageSupplier_Click(object sender, EventArgs e)
        {
            frmSupplier frmSupplier = new frmSupplier();
            frmSupplier.ShowDialog();
        }

        private void mnuManageProduct_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            frmProduct.ShowDialog();
        }

        private void mnuManageCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }

        private void mnuManageAccount_Click(object sender, EventArgs e)
        {
            frmAccount frmAccount = new frmAccount();
            frmAccount.ShowDialog();
        }

        private void mnuManageEmployee_Click(object sender, EventArgs e)
        {
            frmEmployee frmEmployee = new frmEmployee();
            frmEmployee.ShowDialog();
        }

        private void mnuManageCatagory_Click(object sender, EventArgs e)
        {
            frmCatagory frmCatagory = new frmCatagory();
            frmCatagory.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
