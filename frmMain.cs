using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;
using System.Windows.Forms;

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
        private const int PANEL_STEP = 10;
        public frmMain(Account account)
        {
            InitializeComponent();
            this.account = account;
            this.IsMdiContainer = true;
        }
        #endregion
        #region Support Methods
        private void openChildForm(Form form)
        {
            // Check if the form is already open
            Form? existing = this.MdiChildren.FirstOrDefault(f => f.GetType() == form.GetType());
            if (existing != null)
            {
                existing.BringToFront();
                return;
            }
            // Close all child forms before opening a new one
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
            // New child form
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        private void AnimatePanelSize(Panel panel, int targetSize, bool isHorizontal, System.Windows.Forms.Timer timer)
        {
            int step = 10;

            if (isHorizontal)
            {
                if (panel.Width < targetSize)
                {
                    panel.Width += step;
                    if (panel.Width >= targetSize)
                    {
                        panel.Width = targetSize;
                        timer.Stop();
                    }
                }
                else
                {
                    panel.Width -= step;
                    if (panel.Width <= targetSize)
                    {
                        panel.Width = targetSize;
                        timer.Stop();
                    }
                }
            }
            else
            {
                if (panel.Height < targetSize)
                {
                    panel.Height += step;
                    if (panel.Height >= targetSize)
                    {
                        panel.Height = targetSize;
                        timer.Stop();
                    }
                }
                else
                {
                    panel.Height -= step;
                    if (panel.Height <= targetSize)
                    {
                        panel.Height = targetSize;
                        timer.Stop();
                    }
                }
            }
        }

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
        private void btnAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAccount());
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEmployee());
        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSupplier());
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCustomer());
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProduct());
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCatagory());
        }
        private void btnSale_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSale());
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            openChildForm(new frmImport());
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
            openChildForm(new frmUser());
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
            openChildForm(new frmSalaryReport());
        }
        private void btnFinancialReport_Click(object sender, EventArgs e)
        {
            openChildForm(new frmFinancialReport());
        }
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            openChildForm(new frmInvoiceReport());
        }
        #endregion
        #region Tick
        private void menuTransistion_Tick(object sender, EventArgs e)
        {
            int targetWidth = menuExpand ? 72 : 271;
            AnimatePanelSize(pnMenu, targetWidth, true, menuTransistion);

            // Flip the flag only once when finished
            if (pnMenu.Width == targetWidth)
                menuExpand = !menuExpand;
        }
        private void manageTransistion_Tick(object sender, EventArgs e)
        {
            int targetHeight = manageExpand ? 66 : 66 * (numOfManageButton + 1);
            AnimatePanelSize(pnManage, targetHeight, false, manageTransistion);

            if (pnManage.Height == targetHeight)
                manageExpand = !manageExpand;
        }
        private void reportTransistion_Tick(object sender, EventArgs e)
        {
            int targetHeight = reportExpand ? 66 : 66 * (numOfReportButton + 1);
            AnimatePanelSize(pnReport, targetHeight, false, reportTransistion);

            if (pnReport.Height == targetHeight)
                reportExpand = !reportExpand;
        }


        #endregion
        #endregion

    }
}
