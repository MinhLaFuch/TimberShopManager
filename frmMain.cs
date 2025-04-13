using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmMain : Form
    {
        #region Properties
        private Account account;
        private bool manageExpand = false;
        private bool menuExpand = false;
        private bool reportExpand = false;
        private int numOfManageButton = 6;
        private int numOfReportButton = 3;
        public frmMain(Account account)
        {
            InitializeComponent();
            this.account = account;
            this.IsMdiContainer = true;
        }
        #endregion
        #region Support Methods
        #endregion
        #region Events
        #region Load
        private void frmMain_Load(object sender, EventArgs e)
        {

            lblUsername.Text = account.Username;
            //lbName.Text = Employee.ConverRole(account.verifyPermission());
        }
        #endregion
        #region Click
        private void btnCategory_Click(object sender, EventArgs e)
        {
            frmCatagory frmCatagory = new frmCatagory();
            frmCatagory.MdiParent = this;
            frmCatagory.Show();
        }
        private void btnSale_Click(object sender, EventArgs e)
        {
            frmSale frmSale = new frmSale();
            frmSale.MdiParent = this;
            frmSale.Show();
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            frmImport frmImport = new frmImport();
            frmImport.MdiParent = this;
            frmImport.Show();
        }
        private void pbLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void pbUser_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new frmUser();
            frmUser.MdiParent = this;
            frmUser.Show();
        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            manageTransistion.Start();
        }
        private void pbMenu_Click(object sender, EventArgs e)
        {
            menuTransistion.Start();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            reportTransistion.Start();
        }
        private void btnSalary_Click(object sender, EventArgs e)
        {
            frmSalaryReport frmSalaryReport = new frmSalaryReport();
            frmSalaryReport.MdiParent = this;
            frmSalaryReport.Show();
        }

        private void btnFinancialReport_Click(object sender, EventArgs e)
        {
            frmFinancialReport frmFinancialReport = new frmFinancialReport();
            frmFinancialReport.MdiParent = this;
            frmFinancialReport.Show();
        }
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            frmInvoiceReport frmInvoiceReport = new frmInvoiceReport();
            frmInvoiceReport.MdiParent = this;
            frmInvoiceReport.Show();
        }
        #endregion
        #region Tick
        private void manageTransistion_Tick(object sender, EventArgs e)
        {
            if (!manageExpand)
            {
                if (pnManage.Height >= 66 * numOfManageButton)
                {
                    manageExpand = true;
                    manageTransistion.Stop();
                }
                else
                {
                    pnManage.Height += 50;
                }
            }
            else
            {
                if (pnManage.Height <= 66)
                {
                    manageExpand = false;
                    manageTransistion.Stop();
                }
                else
                {
                    pnManage.Height -= 50;
                }
            }
        }
        // Not working
        private void menuTransistion_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
            {
                if (pnMenu.Width >= 271)
                {
                    menuExpand = true;
                    menuTransistion.Stop();
                }
                else
                {
                    pnMenu.Width += 50;
                }
            }
            else
            {
                if (pnMenu.Width <= 72)
                {
                    menuExpand = false;
                    menuTransistion.Stop();
                }
                else
                {
                    pnMenu.Width -= 50;
                }
            }
        }
        
        private void reportTransistion_Tick(object sender, EventArgs e)
        {
            if (!reportExpand)
            {
                if (pnReport.Height >= 66 * numOfReportButton)
                {
                    reportExpand = true;
                    reportTransistion.Stop();
                }
                else
                {
                    pnReport.Height += 50;
                }
            }
            else
            {
                if (pnReport.Height <= 66)
                {
                    reportExpand = false;
                    reportTransistion.Stop();
                }
                else
                {
                    pnReport.Height -= 50;
                }
            }
        }
        #endregion
        #endregion
    }
}
