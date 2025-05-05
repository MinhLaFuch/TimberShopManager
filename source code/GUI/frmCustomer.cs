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
using timber_shop_manager.GUI;
using timber_shop_manager.objects;
using timber_shop_manager.Utils;

namespace timber_shop_manager
{
    public partial class frmCustomer : Form
    {
        #region Properties
        private EmployeeDTO emp;
        private bool authority;
        private readonly CustomerBUS customerBUS = new();
        private readonly SaleBUS salesBUS = new();

        private bool isSearchMode = false;
        private DynamicSearch dynamicSearch;
        public frmCustomer()
        {
            InitializeComponent();
        }
        public frmCustomer(EmployeeDTO emp) : this()
        {
            this.emp = emp;
            authority = (RoleHelper.ConvertToEnum(emp.Role) == RoleEnum.ADMINISTRATOR) || (RoleHelper.ConvertToEnum(emp.Role) == RoleEnum.MANAGER);
        }
        #endregion
        #region Support methods
        private void InitializeUI()
        {
            DisableAllInputsExceptSearch();
            ClearCustomerFields();
            ClearPurchaseHistory();

            ButtonVisibility(true, true, false, false);
        }

        private void DisableAllInputsExceptSearch()
        {
            pnInfo.Enabled = false;
            gbPurchaseHistory.Enabled = false;

            // Explicitly disable text inputs
            txtPhoneNumber.Enabled = false;
            txtName.Enabled = false;
            txtAddress.Enabled = false;
        }

        private void LoadCustomerData()
        {
            dgvCustomer.DataSource = customerBUS.LoadAll();
            if (dgvCustomer.Columns.Contains("IsDeleted"))
            {
                dgvCustomer.Columns["IsDeleted"].Visible = false;
            }

            Dictionary<string, string> columnHeaders = new()
            {
                { "PhoneNumber", "Số điện thoại" },
                { "Name", "Họ tên" },
                { "Address", "Địa chỉ" }
            };

            DataGridViewHelper.SetVietnameseHeaders(dgvCustomer, columnHeaders);
        }

        private void LoadInitialPurchaseData()
        {
            dgvPurchase.DataSource = salesBUS.LoadAllInvoices();

            if (dgvPurchase.Columns.Contains("PhoneNumber"))
                dgvPurchase.Columns["PhoneNumber"].HeaderText = "Customer Phone";
            if (dgvPurchase.Columns.Contains("SalId"))
                dgvPurchase.Columns["SalId"].HeaderText = "Sales Agent";
            if (dgvPurchase.Columns.Contains("TotalCost"))
                dgvPurchase.Columns["TotalCost"].DefaultCellStyle.Format = "N0";

            Dictionary<string, string> columnHeaders = new()
            {
                { "Id", "Mã" },
                { "PhoneNumber", "SĐT Khách hàng" },
                { "SalId", "Nhân viên"},
                { "Address", "Địa chỉ" },
                { "PaymentDate", "Ngày thanh toán"},
                { "TotalCost", "Tổng tiền" },
                { "PaymentMethod", "Phương thức" }
            };

            DataGridViewHelper.SetVietnameseHeaders(dgvPurchase, columnHeaders);
        }
        private void ButtonVisibility(bool searchBtn, bool modBtn, bool saveBtn, bool cancelBtn)
        {
            btnSearch.Visible = searchBtn;
            btnMod.Visible = modBtn && authority;
            btnSave.Visible = saveBtn && authority;
            btnCancel.Visible = cancelBtn;
        }
        private void ClearCustomerFields()
        {
            txtPhoneNumber.Clear();
            txtName.Clear();
            txtAddress.Clear();
        }

        private void ClearPurchaseHistory()
        {
            dgvPurchase.DataSource = null;
            txtInvoiceId.Clear();
        }

        private void EnterSearchMode()
        {
            isSearchMode = true;

            pnInfo.Enabled = true;

            // Enable and make editable
            txtPhoneNumber.Enabled = true;
            txtName.Enabled = true;
            txtAddress.Enabled = true;

            txtPhoneNumber.ReadOnly = false;
            txtName.ReadOnly = false;
            txtAddress.ReadOnly = false;

            // Apply DynamicSearch logic
            dynamicSearch = new DynamicSearch(
                new List<Control> { txtPhoneNumber, txtName, txtAddress },
                new Dictionary<string, string>
                {
            { txtPhoneNumber.Name, "PhoneNumber" },
            { txtName.Name, "Name" },
            { txtAddress.Name, "Address" }
                },
                customerBUS.LoadAll,
                dgvCustomer
            );
            dynamicSearch.Enable();

            // Update UI state
            ButtonVisibility(false, false, false, true);
            // Ensure focus works
            txtPhoneNumber.Focus();
        }
        private void ExitSearchMode()
        {
            isSearchMode = false;

            // Disable inputs
            txtPhoneNumber.Enabled = false;
            txtName.Enabled = false;
            txtAddress.Enabled = false;

            // Detach and dispose dynamic search
            dynamicSearch?.Disable();
            dynamicSearch = null;

            // Clear và load lại dữ liệu như lúc load form
            ClearCustomerFields();
            ClearPurchaseHistory();
            LoadCustomerData();
            LoadInitialPurchaseData(); // ✅ bổ sung

            // Reset UI giống lúc khởi tạo
            InitializeUI();
        }
        private void LoadCustomerInvoices()
        {
            string phone = txtPhoneNumber.Text.Trim();
            DateTime from = dtpTimeFrom.Value.Date;
            DateTime to = dtpTimeTo.Value.Date.AddDays(1).AddTicks(-1); // bao gồm toàn bộ ngày

            DataTable allInvoices = salesBUS.LoadAllInvoices();

            // Lọc theo thời gian
            var filteredRows = allInvoices.AsEnumerable()
                .Where(row =>
                {
                    var date = row.Field<DateTime>("PaymentDate");
                    bool matchPhone = string.IsNullOrEmpty(phone) || row.Field<string>("PhoneNumber") == phone;
                    return matchPhone && date >= from && date <= to;
                });

            DataTable result = filteredRows.Any() ? filteredRows.CopyToDataTable() : new DataTable();
            dgvPurchase.DataSource = result;
            //txtInvoiceId.Text = result.Rows.Count.ToString();

            gbPurchaseHistory.Enabled = true;
            UpdateDateTimePickerBounds();
        }

        private void UpdateDateTimePickerBounds()
        {
            DateTime now = DateTime.Now;

            if (gbPurchaseHistory.Enabled || dtpTimeFrom.Enabled || dtpTimeTo.Enabled)
            {
                // Set max của dtpTimeTo là thời điểm hiện tại
                dtpTimeTo.MaxDate = now;

                // Đảm bảo dtpTimeFrom không lớn hơn max của dtpTimeTo
                dtpTimeFrom.MaxDate = dtpTimeTo.Value;
                if (dtpTimeFrom.Value > dtpTimeFrom.MaxDate)
                {
                    dtpTimeFrom.Value = dtpTimeFrom.MaxDate;
                }

                // Ngược lại, đảm bảo dtpTimeTo không nhỏ hơn min của dtpTimeFrom
                dtpTimeTo.MinDate = dtpTimeFrom.Value;
                if (dtpTimeTo.Value < dtpTimeTo.MinDate)
                {
                    dtpTimeTo.Value = dtpTimeTo.MinDate;
                }
            }
        }
        #endregion
        #region Load
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            InitializeUI();
            LoadCustomerData();
            LoadInitialPurchaseData();
        }
        #endregion
        #region Button click event
        private void btnMod_Click(object sender, EventArgs e)
        {
            // Kích hoạt chỉnh sửa
            pnInfo.Enabled = true;
            txtPhoneNumber.Enabled = false; // KHÔNG cho sửa khóa chính
            txtName.Enabled = true;
            txtAddress.Enabled = true;

            ButtonVisibility(false, false, true, true);

            gbPurchaseHistory.Enabled = false; // Vô hiệu hóa lịch sử
            txtInvoiceId.Clear();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            EnterSearchMode();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var controlsToValidate = new Dictionary<Control, Label>
                {
                    { txtPhoneNumber, lbPhoneNumber },
                    { txtName, lbName },
                    { txtAddress, lbAddress }
                };

            // Kiểm tra bỏ trống
            if (!InputValidator.ValidateNotEmpty(controlsToValidate))
                return;

            // Tạo DTO
            var customer = new CustomerDTO
            {
                PhoneNumber = txtPhoneNumber.Text.Trim(),
                Name = InputValidator.CapitalizeName(txtName.Text.Trim()),
                Address = txtAddress.Text.Trim()
            };

            // Lưu DB qua BUS
            customerBUS.SaveCustomer(customer);

            MessageBox.Show("Lưu thông tin khách hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reload form
            InitializeUI();
            LoadCustomerData();
            LoadInitialPurchaseData();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            InitializeUI();
            LoadCustomerData();
            LoadInitialPurchaseData();
        }
        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            new frmInvoiceDetail(txtInvoiceId.Text).ShowDialog();
        }
        #endregion
        #region Cell click event
        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (isSearchMode)
                {
                    ExitSearchMode();
                }

                string phone = dgvCustomer.Rows[e.RowIndex].Cells["PhoneNumber"].Value?.ToString();
                if (string.IsNullOrEmpty(phone)) return;

                CustomerDTO customer = customerBUS.GetCustomer(phone);
                if (customer == null) return;

                txtPhoneNumber.Text = customer.PhoneNumber;
                txtName.Text = customer.Name;
                txtAddress.Text = customer.Address;

                ButtonVisibility(true, true, false, false);
                pnInfo.Enabled = false;

                LoadCustomerInvoices();
            }
        }
        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvPurchase.Rows[e.RowIndex];
                var invoiceId = row.Cells["Id"].Value?.ToString(); // Đảm bảo cột "Id" là mã hoá đơn
                txtInvoiceId.Text = invoiceId ?? "";
            }
            else
            {
                btnMod.Visible = false;
            }
        }
        #endregion
        #region Enable Changed event
        private void gbPurchaseHistory_EnabledChanged(object sender, EventArgs e)
        {
            if (gbPurchaseHistory.Enabled)
                UpdateDateTimePickerBounds();
        }
        #endregion
        #region Value Changed Event
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            UpdateDateTimePickerBounds();
            LoadCustomerInvoices();
        }
        private void txtInvoiceId_TextChanged(object sender, EventArgs e)
        {
            btnViewDetail.Visible = !string.IsNullOrWhiteSpace(txtInvoiceId.Text);
        }
        #endregion

    }
}
