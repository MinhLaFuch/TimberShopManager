using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timber_shop_manager.BUS;
using timber_shop_manager.DTO;
using timber_shop_manager.objects;
using timber_shop_manager.Utils;

namespace timber_shop_manager.GUI
{
    public partial class frmSupplier : Form
    {
        #region Properties
        private readonly EmployeeDTO emp;
        private bool authority;
        private readonly SupplierBUS supplierBUS = new();
        private readonly ImportInvoiceBUS importInvoiceBUS = new();

        private bool isSearchMode = false;
        private DynamicSearch dynamicSearch;
        public frmSupplier()
        {
            InitializeComponent();
        }

        public frmSupplier(EmployeeDTO emp) : this()
        {
            this.emp = emp;
            authority = (RoleHelper.ConvertToEnum(emp.Role) == RoleEnum.ADMINISTRATOR) || (RoleHelper.ConvertToEnum(emp.Role) == RoleEnum.MANAGER);
        }
        #endregion
        #region Support method
        private void LoadForm()
        {
            InitializeUI();
            LoadSupplierData();
            LoadInitialImportData();
            ExitSearchMode();
        }
        private void ButtonVisibility(bool featureBtn, bool cellBtn, bool saveBtn, bool cancelBtn)
        {
            btnAdd.Visible = featureBtn && authority;
            btnSearch.Visible = featureBtn;
            btnMod.Visible = btnDelete.Visible = cellBtn && authority;
            btnSave.Visible = saveBtn && authority;
            btnCancel.Visible = cancelBtn;
        }
        private void InitializeUI()
        {
            DisableAllInputsExceptSearch();
            ClearSupplierFields();
            ClearImportHistory();

            ButtonVisibility(true, false, false, false);
        }
        private void DisableAllInputsExceptSearch()
        {
            pnInfo.Enabled = false;
            gbPurchaseHistory.Enabled = false;

            txtId.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtWebsite.Enabled = false;
        }
        private void ClearSupplierFields()
        {
            txtId.Clear();
            txtPhoneNumber.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtWebsite.Clear();
        }
        private void ClearImportHistory()
        {
            dgvPurchase.DataSource = null;
            txtInvoiceId.Clear();
        }
        private void LoadSupplierData()
        {
            dgvSupplier.DataSource = supplierBUS.GetAll();
            if (dgvSupplier.Columns.Contains("IsDeleted"))
            {
                dgvSupplier.Columns["IsDeleted"].Visible = false;
            }

            Dictionary<string, string> columnHeaders = new()
            {
                { "Id", "Mã" },
                { "Name", "Tên" },
                { "Address", "Địa chỉ"},
                { "ContactNumber", "SĐT" },
            };

            DataGridViewHelper.SetVietnameseHeaders(dgvSupplier, columnHeaders);
        }
        private void LoadInitialImportData()
        {
            dgvPurchase.DataSource = importInvoiceBUS.LoadAllImportInvoices();
            if (dgvPurchase.Columns.Contains("SupId"))
                dgvPurchase.Columns["SupId"].HeaderText = "Supplier ID";
            if (dgvPurchase.Columns.Contains("ManId"))
                dgvPurchase.Columns["ManId"].HeaderText = "Manager ID";
            if (dgvPurchase.Columns.Contains("TotalPrice"))
                dgvPurchase.Columns["TotalPrice"].DefaultCellStyle.Format = "N0";

            Dictionary<string, string> columnHeaders = new()
            {
                { "Id", "Mã hoá đơn" },
                { "SupId", "Mã nhà cung cấp" },
                { "ManId", "Nhân viên"},
                { "PaymentDate", "Ngày thanh toán" },
                { "TotalPrice", "Tổng tiền" },
                {"PaymentMethod", "Phương thức thanh toán"}
            };

            DataGridViewHelper.SetVietnameseHeaders(dgvPurchase, columnHeaders);
            DataGridViewHelper.FormatDateColumns(dgvPurchase, "PaymentDate");
        }
        private void LoadSupplierImportInvoices()
        {
            string supId = txtId.Text.Trim();
            DateTime from = dtpTimeFrom.Value.Date;
            DateTime to = dtpTimeTo.Value.Date.AddDays(1).AddTicks(-1);

            DataTable allInvoices = importInvoiceBUS.LoadAllImportInvoices();

            var filteredRows = allInvoices.AsEnumerable()
                .Where(row =>
                {
                    var date = row.Field<DateTime>("PaymentDate");
                    bool matchSup = string.IsNullOrEmpty(supId) || row.Field<string>("SupId") == supId;
                    return matchSup && date >= from && date <= to;
                });

            DataTable result = filteredRows.Any() ? filteredRows.CopyToDataTable() : new DataTable();
            dgvPurchase.DataSource = result;

            gbPurchaseHistory.Enabled = true;
            UpdateDateTimePickerBounds();
        }
        private void UpdateDateTimePickerBounds()
        {
            DateTime now = DateTime.Now;
            dtpTimeTo.MaxDate = now;
            dtpTimeFrom.MaxDate = now;
        }
        private void EnterSearchMode()
        {

            isSearchMode = true;

            txtId.Enabled = true;
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtEmail.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtWebsite.Enabled = true;

            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtWebsite.Clear();

            dynamicSearch = new DynamicSearch(
                new List<Control> { txtId, txtName, txtAddress },
                new Dictionary<string, string>
                {
                    { txtId.Name, "Id" },
                    { txtName.Name, "Name" },
                    { txtAddress.Name, "Address" },
                    { txtEmail.Name, "Email" },
                    { txtPhoneNumber.Name, "ContactNumber" },
                    { txtWebsite.Name, "Website" }
                },
                supplierBUS.GetAll,
                dgvSupplier
            );
            dynamicSearch.Enable();
            
            ButtonVisibility(false, false, false, true);

            pnInfo.Enabled = true;
            gbInfo.Enabled = true;
        }


        private void ExitSearchMode()
        {
            isSearchMode = false;

            txtId.Enabled = false;
            txtName.Enabled = false;
            txtAddress.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNumber.Enabled = false;
            txtWebsite.Enabled = false;

            dynamicSearch?.Disable();
            dynamicSearch = null;

            ClearSupplierFields();
            ClearImportHistory();
            LoadSupplierData();
            LoadInitialImportData();
        }
        #endregion
        #region Load event
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion
        #region Button click event
        private void btnSave_Click(object sender, EventArgs e)
        {
            var supplier = new SupplierDTO
            {
                Id = txtId.Text.Trim(),
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Website = txtWebsite.Text.Trim()
            };

            supplierBUS.SaveSupplier(supplier);

            MessageBox.Show("Lưu thông tin nhà cung cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            InitializeUI();
            LoadSupplierData();
            LoadInitialImportData();
        }
        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            string invoiceId = txtInvoiceId.Text.Trim();
            if (string.IsNullOrEmpty(invoiceId))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xem.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmInvoiceDetail detailForm = new frmInvoiceDetail(invoiceId, false);
            detailForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            InitializeUI();
            LoadSupplierData();
            ExitSearchMode();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
                EnterSearchMode();
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            pnInfo.Enabled = true;
            txtId.Enabled = false;
            ButtonVisibility(false, false, true, true);
            gbPurchaseHistory.Enabled = false;
            txtInvoiceId.Clear();

            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtWebsite.Enabled = true;
            txtEmail.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            supplierBUS.DeleteSupplier(supplierBUS.GetSupplierById(txtId.Text));
            LoadForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnInfo.Enabled = true;
            // Đặt trạng thái thêm mới
            //isAdding = true;

            // Gán ID tiếp theo
            txtId.Text = supplierBUS.GenerateNextSupplierId();

            // Khóa ô ID lại
            txtId.Enabled = false;

            // Mở các ô nhập liệu khác
            txtName.Enabled = true;
            txtAddress.Enabled = true;
            txtPhoneNumber.Enabled = true;
            txtWebsite.Enabled = true;
            txtEmail.Enabled = true;

            // Xóa nội dung cũ (nếu có)
            txtName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtWebsite.Clear();
            txtEmail.Clear();

            // Focus vào ô Name
            txtName.Focus();
            ButtonVisibility(false, false, true, true);
        }
        #endregion
        #region Cell click event
        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ButtonVisibility(true, true, false, false);
                if (isSearchMode)
                {
                    ExitSearchMode();
                }

                string id = dgvSupplier.Rows[e.RowIndex].Cells["Id"].Value?.ToString();
                if (string.IsNullOrEmpty(id)) return;

                SupplierDTO supplier = supplierBUS.GetSupplierById(id);
                if (supplier == null) return;

                txtId.Text = supplier.Id;
                txtName.Text = supplier.Name;
                txtPhoneNumber.Text = supplier.PhoneNumber;
                txtAddress.Text = supplier.Address;
                txtEmail.Text = supplier.Email;
                txtWebsite.Text = supplier.Website;

                LoadSupplierImportInvoices();
                txtInvoiceId.Clear();
            }
        }
        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string invoiceId = dgvPurchase.Rows[e.RowIndex].Cells["Id"].Value?.ToString();
                txtInvoiceId.Text = invoiceId;
                btnViewDetail.Visible = true;
            }
        }
        #endregion
        #region Enable Change event
        private void gbPurchaseHistory_EnabledChanged(object sender, EventArgs e)
        {
            UpdateDateTimePickerBounds();
        }
        #endregion
        #region Value Changed event
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            LoadSupplierImportInvoices();
        }
        private void txtInvoiceId_TextChanged(object sender, EventArgs e)
        {
            btnViewDetail.Enabled = !string.IsNullOrWhiteSpace(txtInvoiceId.Text);
        }
        #endregion
        #region KeyPress event
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.CheckInputIsDigit(e);
        }
        #endregion
    }
}
