using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using timber_shop_manager.BUS;
using timber_shop_manager.DTO;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmAccount : Form
    {
        #region Properties
        private bool searchMode = false;
        private AccountDTO selectedAccount = null;
        private EmployeeDTO emp;
        private DynamicSearch dynamicSearch = null;
        private readonly AccountBUS accountBUS = new AccountBUS();

        public frmAccount()
        {
            InitializeComponent();
        }
        public frmAccount(EmployeeDTO emp) : this() => this.emp = emp;
        #endregion
        #region Support methods
        private void LoadForm()
        {
            ExitSearchMode();
            ClearInput();
            LoadData();
            EnterDefaultMode();
        }
        private void LoadData()
        {
            dgv.DataSource = accountBUS.GetAccountsForGrid();

            // Ẩn cột không cần hiển thị
            dgv.Columns["IsActivate"].Visible = false;
            dgv.Columns["SortOrder"].Visible = false;

            cbRole.DataSource = accountBUS.GetDistinctRoles();
            cbRole.SelectedIndex = -1;
        }

        private void EnterDefaultMode()
        {
            EnableInputFields(false);
            txtEmail.Enabled = false;

            ButtonVisibility(true, false, false);
            searchMode = false;
        }

        private void EnterSearchMode()
        {
            pnInfo.Enabled = true;
            ClearInput();
            txtEmail.Enabled = true;
            EnableInputFields(true);

            txtEmail.Focus();
            ButtonVisibility(false, true, false);

            searchMode = true;
            SetupDynamicSearch();
        }


        private void ExitSearchMode()
        {
            if (!searchMode) return;

            searchMode = false;
            dynamicSearch?.Disable();
            LoadData();
            txtID.Enabled = false;
        }
        private void SetupDynamicSearch()
        {
            if (dynamicSearch != null)
            {
                dynamicSearch.Enable();
                return;
            }

            var controls = new List<Control> { txtID, txtName, txtEmail, cbRole };
            var columnMappings = new Dictionary<string, string>
            {
                { "txtID", "Mã" },
                { "txtName", "Tên" },
                { "txtUsername", "Tên tài khoản" },
                { "cbRole", "Chức vụ" }
            };

            dynamicSearch = new DynamicSearch(controls, columnMappings, accountBUS.GetAccountsForGrid, dgv);
            dynamicSearch.Enable();
        }
        private void EnableInputFields(bool enable)
        {
            txtID.Enabled = enable;
            txtName.Enabled = enable;
            cbRole.Enabled = enable;
        }
        private void ClearInput()
        {
            txtID.Clear();
            txtName.Clear();
            txtEmail.Clear();
            cbRole.SelectedIndex = -1;
        }
        private void UpdateControlStateBasedOnRow(DataGridViewRow row)
        {
            var email = row.Cells["Tên tài khoản"].Value?.ToString();
            var id = row.Cells["Mã"].Value?.ToString();
            var hasAccount = !string.IsNullOrWhiteSpace(email);
            var isLocked = hasAccount && Convert.ToInt32(row.Cells["IsActivate"]?.Value) == 0;

            if (!hasAccount)
            {
                selectedAccount = null;
                btnLock.Visible = false;
                txtEmail.Enabled = true;
            }
            else
            {
                selectedAccount = new AccountDTO(email, id);
                btnLock.Visible = true;
                txtEmail.Enabled = false;
            }
        }
        private void ButtonVisibility(bool defaultBtn, bool cancelBtn, bool lockBtn)
        {
            btnCreate.Visible = btnSearch.Visible = defaultBtn;
            btnCancel.Visible = cancelBtn;
            btnLock.Visible = lockBtn;
        }
        #endregion
        #region Load events
        private void frmAccount_Load(object sender, EventArgs e) => LoadForm();
        #endregion
        #region Button click events
        private void btnLock_Click(object sender, EventArgs e)
        {
            if (selectedAccount == null) return;

            var confirm = MessageBox.Show("Bạn có chắc chắn khoá tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                accountBUS.BlockAccount(selectedAccount.Email);
                LoadForm();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) => LoadForm();
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!searchMode)
                EnterSearchMode();
            else
                LoadForm();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text.Trim();
            var employeeId = txtID.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Email không được để trống.");
                return;
            }

            try
            {
                var acc = new AccountDTO(email, employeeId);
                accountBUS.CreateAccount(acc);
                new frmChangePW(this, email).ShowDialog();
                MessageBox.Show("Tạo tài khoản thành công!");
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Cell click event
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgv.Rows[e.RowIndex].Cells["Mã"].Value == null)
            {
                ExitSearchMode();
                EnterDefaultMode();
                return;
            }

            var row = dgv.Rows[e.RowIndex];

            txtID.Text = row.Cells["Mã"].Value?.ToString();
            txtName.Text = row.Cells["Tên"].Value?.ToString();
            txtEmail.Text = row.Cells["Tên tài khoản"].Value?.ToString();
            cbRole.Text = row.Cells["Chức vụ"].Value?.ToString();

            UpdateControlStateBasedOnRow(row);
        }
        #endregion
        #region Key press event
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.CheckInputIsLetter(e);
        }
        #endregion
        #region DataBindingComplete event
        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var username = row.Cells["Tên tài khoản"].Value?.ToString();
                var isActiveObj = row.Cells["IsActivate"].Value;

                if (string.IsNullOrWhiteSpace(username))
                    row.DefaultCellStyle.BackColor = Color.Orange;
                else if (isActiveObj != null && Convert.ToInt32(isActiveObj) == 0)
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
        }
        #endregion
    }
}
