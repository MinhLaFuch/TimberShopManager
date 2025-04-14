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
            // Remove existing form
            foreach (Control ctrl in pnMDI.Controls)
            {
                ctrl.Dispose(); // Free memory/resources
            }
            pnMDI.Controls.Clear(); // Remove all references

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            pnMDI.Controls.Add(form);
            pnMDI.Tag = form;
            form.BringToFront();
            form.Show();
        }
        private void AnimatePanelSize(Panel panel, int targetSize, bool isHorizontal, System.Windows.Forms.Timer timer)
        {
            timer.Interval = 10;
            if (isHorizontal)
            {
                if (panel.Width < targetSize)
                {
                    panel.Width += PANEL_STEP;
                    if (panel.Width >= targetSize)
                    {
                        panel.Width = targetSize;
                        timer.Stop();
                    }
                }
                else
                {
                    panel.Width -= PANEL_STEP;
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
                    panel.Height += PANEL_STEP;
                    if (panel.Height >= targetSize)
                    {
                        panel.Height = targetSize;
                        timer.Stop();
                    }
                }
                else
                {
                    panel.Height -= PANEL_STEP;
                    if (panel.Height <= targetSize)
                    {
                        panel.Height = targetSize;
                        timer.Stop();
                    }
                }
            }
        }
        private void loadFormBasedOnRole()
        {
            if (account.verifyPermission() == Employee.Role.ADMINISTRATOR)
            {
                // Manage
                btnAccount.Visible = true;
                btnEmployee.Visible = false;
                btnSupplier.Visible = true;
                btnCustomer.Visible = true;
                btnProduct.Visible = true;
                btnCategory.Visible = true;
                // Sale
                btnSale.Visible = true;
                // Import
                btnImport.Visible = true;
                // Report
                btnSalary.Visible = false;
                btnFinancialReport.Visible = false;
                btnInvoice.Visible = true;
            }
            else if (account.verifyPermission() == Employee.Role.MANAGER)
            {
                // Manage
                btnAccount.Visible = false;
                btnEmployee.Visible = true;
                btnSupplier.Visible = true;
                btnCustomer.Visible = true;
                btnProduct.Visible = true;
                btnCategory.Visible = true;
                // Sale
                btnSale.Visible = true;
                // Import
                btnImport.Visible = false;
                // Report
                btnSalary.Visible = false;
                btnFinancialReport.Visible = false;
                btnInvoice.Visible = true;
            }
            else if (account.verifyPermission() == Employee.Role.SALE_AGENT)
            {
                // Manage
                btnAccount.Visible = false;
                btnEmployee.Visible = false;
                btnSupplier.Visible = false;
                btnCustomer.Visible = true;
                btnProduct.Visible = true;
                btnCategory.Visible = true;
                // Sale
                btnSale.Visible = true;
                // Import
                btnImport.Visible = false;
                // Report
                btnSalary.Visible = false;
                btnFinancialReport.Visible = false;
                btnInvoice.Visible = true;
            }
            else if (account.verifyPermission() == Employee.Role.ACCOUNTANT)
            {
                // Manage
                btnAccount.Visible = false;
                btnEmployee.Visible = false;
                btnSupplier.Visible = false;
                btnCustomer.Visible = true;
                btnProduct.Visible = true;
                btnCategory.Visible = true;
                // Sale
                btnSale.Visible = false;
                // Import
                btnImport.Visible = false;
                // Report
                btnSalary.Visible = true;
                btnFinancialReport.Visible = true;
                btnInvoice.Visible = true;
            }
        }
        #endregion
        #region Events
        #region Load
        private void frmMain_Load(object sender, EventArgs e)
        {
            pnMenu.VerticalScroll.Enabled = false;
            pnMenu.VerticalScroll.Visible = false;
            pnMenu.HorizontalScroll.Enabled = false;
            pnMenu.HorizontalScroll.Visible = false;
            lbUsername.Text = account.Username;
            loadFormBasedOnRole();
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
            int targetHeight = manageExpand ? 66 : 66 * (pnManage.Controls.Count + 1);
            AnimatePanelSize(pnManage, targetHeight, false, manageTransistion);

            if (pnManage.Height == targetHeight)
                manageExpand = !manageExpand;
        }
        private void reportTransistion_Tick(object sender, EventArgs e)
        {
            int targetHeight = reportExpand ? 66 : 66 * (pnReport.Controls.Count + 1);
            AnimatePanelSize(pnReport, targetHeight, false, reportTransistion);

            if (pnReport.Height == targetHeight)
                reportExpand = !reportExpand;
        }
        #endregion
        #endregion

    }
}
