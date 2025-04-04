namespace timber_shop_manager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
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
    }
}
