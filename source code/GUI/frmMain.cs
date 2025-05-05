using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;
using System.Windows.Forms;
using timber_shop_manager.DTO;
using timber_shop_manager.GUI;

namespace timber_shop_manager
{
    public partial class frmMain : Form
    {

        private EmployeeDTO emp;
        private bool manageExpand = false;
        private bool reportExpand = false;
        private int pnManageQuantity = 1;
        private int pnReportQuantity = 1;
        private static ToolTip toolTip = new ToolTip();
        private static Color outerBtnColor = Color.FromArgb(59, 93, 79);
        private static Color innerBtnColor = Color.FromArgb(59, 93, 60);
        private static int buttonHeight = 65;
        public frmMain(EmployeeDTO emp)
        {
            InitializeComponent();
            this.emp = emp;
            this.IsMdiContainer = true;
        }

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
            // Disable scrollbars during animation to prevent glitches
            panel.AutoScroll = false;

            timer.Interval = 15; // Slightly slower interval for smoother animation
            int step = Math.Max(1, Math.Abs(targetSize - (isHorizontal ? panel.Width : panel.Height)) / 10);
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
        private void loadFormBasedOnRole()
        {
            RoleEnum role = RoleHelper.ConvertToEnum(emp.Role);

            if (role == RoleEnum.ADMINISTRATOR)
            {
                // Manage
                btnAccount.Visible = true;
                btnEmployee.Visible = false;
                btnSupplier.Visible = true;
                btnCustomer.Visible = true;
                btnProduct.Visible = true;
                btnCategory.Visible = true;
                btnVoucher.Visible = true;
                pnManageQuantity = 7;
                // Sale
                btnSale.Visible = false;
                // Import
                btnImport.Visible = false;
                // Attend
                btnAttend.Visible = true;
                // Report
                pnReport.Visible = false;
                pnReportQuantity = 0;
            }
            else if (role == RoleEnum.MANAGER)
            {
                // Manage
                btnAccount.Visible = false;
                btnEmployee.Visible = true;
                btnSupplier.Visible = true;
                btnCustomer.Visible = true;
                btnProduct.Visible = true;
                btnCategory.Visible = true;
                btnVoucher.Visible = true;
                pnManageQuantity = 7;
                // Sale
                btnSale.Visible = false;
                // Import
                btnImport.Visible = true;
                // Report
                pnReport.Visible = false;
                pnReportQuantity = 0;
                // Attend
                btnAttend.Visible = false;
            }
            else if (role == RoleEnum.SALE_AGENT)
            {
                // Manage
                btnAccount.Visible = false;
                btnEmployee.Visible = false;
                btnSupplier.Visible = false;
                btnCustomer.Visible = true;
                btnProduct.Visible = true;
                btnCategory.Visible = true;
                btnVoucher.Visible = true;
                pnManageQuantity = 5;
                // Sale
                btnSale.Visible = true;
                // Import
                btnImport.Visible = false;
                // Report
                pnReport.Visible = false;
                pnReportQuantity = 0;
            }
            else if (role == RoleEnum.ACCOUNTANT)
            {
                // Manage
                btnAccount.Visible = false;
                btnEmployee.Visible = false;
                btnSupplier.Visible = false;
                btnCustomer.Visible = true;
                btnProduct.Visible = true;
                btnCategory.Visible = true;
                btnVoucher.Visible = true;
                pnManageQuantity = 5;
                // Sale
                btnSale.Visible = false;
                // Import
                btnImport.Visible = false;
                // Report
                btnSalary.Visible = true;
                btnFinancialReport.Visible = true;
                pnReportQuantity = 3;
            }
        }
        private void ResetButtonColors()
        {
            foreach (Control control in pnMenu.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = outerBtnColor;
                }
                if (control is Panel panel)
                {
                    int i = 0;
                    foreach (Control innerControl in panel.Controls)
                    {
                        if (innerControl is Button innerButton)
                        {
                            innerButton.BackColor = i > 0 ? innerBtnColor : outerBtnColor;
                            i++;
                        }
                    }
                }
            }
            foreach (Control control in pnTop.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.Transparent;
                }
            }
        }
        private void HighlightButton(Button clickedButton)
        {
            ResetButtonColors();
            clickedButton.BackColor = Color.FromArgb(0, 100, 0); // Slightly darker green
        }
        #region Event
        #region Load
        private void frmMain_Load(object sender, EventArgs e)
        {
            pnMenu.VerticalScroll.Enabled = false;
            pnMenu.VerticalScroll.Visible = false;
            pnMenu.HorizontalScroll.Enabled = false;
            pnMenu.HorizontalScroll.Visible = false;
            pnManage.Height = btnManage.Height;
            pnReport.Height = btnReport.Height;
            lbUsername.Text = emp.Name;
            loadFormBasedOnRole();
        }
        #endregion
        #region Click
        private void btnAccount_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAccount(emp));
            HighlightButton((Button)sender);
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEmployee(emp));
            HighlightButton((Button)sender);
        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSupplier(emp));
            HighlightButton((Button)sender);
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCustomer(emp));
            HighlightButton((Button)sender);
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProduct(emp));
            HighlightButton((Button)sender);
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCategory(emp));
            HighlightButton((Button)sender);
        }
        private void btnSale_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSale(emp));
            HighlightButton((Button)sender);
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            openChildForm(new frmImport(emp));
            HighlightButton((Button)sender);
        }
        private void btnUser_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUser(emp));
        }
        private void btnManage_Click(object sender, EventArgs e)
        {
            manageTransistion.Start();
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            reportTransistion.Start();
        }
        private void btnSalary_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSalaryReport(emp));
            HighlightButton((Button)sender);
        }
        private void btnFinancialReport_Click(object sender, EventArgs e)
        {
            openChildForm(new frmFinancial(emp));
            HighlightButton((Button)sender);
        }
        private void btnAttend_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAttendance(emp));
            HighlightButton((Button)sender);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                this.Close();
                (new frmLogin()).Show();
            }
        }
        private void btnVoucher_Click(object sender, EventArgs e)
        {
            openChildForm(new frmVoucher(emp));
            HighlightButton((Button)sender);
        }
        #endregion
        #region Tick
        private void manageTransistion_Tick(object sender, EventArgs e)
        {
            int targetHeight = manageExpand ? buttonHeight : buttonHeight * pnManageQuantity;
            AnimatePanelSize(pnManage, targetHeight, false, manageTransistion);

            if (pnManage.Height == targetHeight)
                manageExpand = !manageExpand;
        }
        private void reportTransistion_Tick(object sender, EventArgs e)
        {
            int targetHeight = reportExpand ? buttonHeight : buttonHeight * pnReportQuantity;
            AnimatePanelSize(pnReport, targetHeight, false, reportTransistion);

            if (pnReport.Height == targetHeight)
                reportExpand = !reportExpand;
        }
        #endregion
        #region Hover
        private void btnSale_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnSale, "Bán hàng");
        }

        private void btnImport_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnImport, "Nhập hàng");
        }

        private void btnAttend_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAttend, "Chấm công");
        }

        private void btnManage_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnManage, "Quản lý");
        }

        private void btnAccount_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnAccount, "Tài khoản");
        }

        private void btnEmployee_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnEmployee, "Nhân viên");
        }

        private void btnSupplier_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnSupplier, "Nhà cung cấp");
        }

        private void btnCustomer_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnCustomer, "Khách hàng");
        }

        private void btnProduct_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnProduct, "Sản phẩm");
        }

        private void btnCategory_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnCategory, "Danh mục");
        }

        private void btnReport_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnReport, "Báo cáo");
        }

        private void btnFinancialReport_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnFinancialReport, "Tài chính");
        }

        private void btnSalary_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnSalary, "Tiền lương");
        }
        private void btnVoucher_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnVoucher, "Khuyến mãi");
        }
        #endregion
        #endregion
    }
}
