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
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmAccount : Form
    {
        private bool searchMode = false;
        private Account selectedAccount = null;
        private Employee.Role role = Employee.Role.UNKNOWN;
        private static DatabaseHelper dbHelper = new DatabaseHelper();
        private DynamicSearch dynamicSearch = null;

        public frmAccount()
        {
            InitializeComponent();
        }
        public frmAccount(Employee.Role role)
        {
            this.role = role;
        }

        private void LoadForm()
        {
            ExitSearchMode();
            ClearInput();
            LoadData();
            EnterDefaultMode();
        }

        private void LoadData()
        {
            dgv.DataSource = LoadDataGridView();
            if (dgv.Columns.Contains("IsActivate"))
                dgv.Columns["IsActivate"].Visible = false;

            if (dgv.Columns.Contains("SortOrder"))
                dgv.Columns["SortOrder"].Visible = false;

            cbRole.DataSource = LoadRoleComboBox();
            cbRole.SelectedIndex = -1;
        }

        private List<string> LoadRoleComboBox()
        {
            string query = "SELECT DISTINCT Role FROM Employee ORDER BY Role";
            return dbHelper.GetDataForComboBox(query, "Role");
        }

        private DataTable LoadDataGridView()
        {
            string query = @"
                SELECT 
                    emp.Id AS 'Mã',
                    emp.Name AS 'Tên',
                    acc.Email AS 'Tên tài khoản',
                    emp.Role AS 'Chức vụ',
                    ISNULL(acc.IsActivate, 1) AS IsActivate,
                    CASE 
                        WHEN acc.Email IS NULL THEN 0            
                        WHEN acc.IsActivate = 0 THEN 2           
                        ELSE 1                                    
                    END AS SortOrder
                FROM Employee emp
                LEFT JOIN Account acc ON emp.Id = acc.Id
                ORDER BY SortOrder, emp.Id";

            return dbHelper.ExecuteQuery(query);
        }

        private void EnterDefaultMode()
        {
            //pnInfo.Enabled = false;
            EnableInputFields(false);

            txtEmail.Enabled = false;

            btnCreate.Enabled = true;
            btnSearch.Enabled = true;
            btnCancel.Enabled = false;
            btnLock.Enabled = false;

            btnSearch.Text = "Tìm kiếm";
            searchMode = false;
        }

        private void EnterSearchMode()
        {
            pnInfo.Enabled = true;
            ClearInput();
            EnableInputFields(true);

            txtID.Enabled = true;
            txtName.Enabled = true;
            cbRole.Enabled = true;

            txtEmail.Focus();

            btnCreate.Enabled = false;
            btnCancel.Enabled = true;
            btnSearch.Text = "Huỷ tìm";

            searchMode = true;
            SetupDynamicSearch();
        }


        private void ExitSearchMode()
        {
            if (!searchMode) return;

            searchMode = false;
            btnSearch.Text = "Tìm kiếm";
            dynamicSearch?.Disable();
            dgv.DataSource = LoadDataGridView();
            txtID.Enabled = false;
        }


        private void SetupDynamicSearch()
        {
            if (dynamicSearch != null)
            {
                dynamicSearch.Enable();
                return;
            }

            List<Control> searchControls = new() { txtID, txtName, txtEmail, cbRole };
            Dictionary<string, string> columnMappings = new()
            {
                { "txtID", "Mã" },
                { "txtName", "Tên" },
                { "txtUsername", "Tên tài khoản" },
                { "cbRole", "Chức vụ" }
            };

            dynamicSearch = new DynamicSearch(searchControls, columnMappings, LoadDataGridView, dgv);
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

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (selectedAccount == null) return;

            var confirm = MessageBox.Show("Bạn có chắc chắn khoá tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                Account.block(selectedAccount);
                LoadForm();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExitSearchMode();
            LoadForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!searchMode)
                EnterSearchMode();
            else
                LoadForm();
        }

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

            bool hasAccount = !string.IsNullOrWhiteSpace(txtEmail.Text);
            bool isLocked = false;

            UpdateControlStateBasedOnRow(row);
        }

        private void UpdateControlStateBasedOnRow(DataGridViewRow row)
        {
            string email = row.Cells["Tên tài khoản"].Value?.ToString();
            string id = row.Cells["Mã"].Value?.ToString();
            bool hasAccount = !string.IsNullOrWhiteSpace(email);
            bool isLocked = false;

            if (hasAccount && row.Cells["IsActivate"]?.Value != null)
                isLocked = Convert.ToInt32(row.Cells["IsActivate"].Value) == 0;

            if (!hasAccount)
            {
                selectedAccount = null;
                btnCreate.Enabled = true;
                btnLock.Enabled = false;
                txtEmail.Enabled = true;
            }
            else
            {
                selectedAccount = new Account(email, id);
                btnCreate.Enabled = false;
                btnLock.Enabled = true;
                txtEmail.Enabled = false;
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            var requiredFields = new Dictionary<Control, Label>
            {
                { txtEmail, lbEmail },
            };

            if (!InputValidator.ValidateNotEmpty(requiredFields))
                return;

            var acc = new Account(txtEmail.Text, txtID.Text);
            if (acc.exists())
            {
                MessageBox.Show("Tài khoản đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account.create(acc);
            MessageBox.Show("Tạo tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadForm();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputValidator.CheckInputIsLetter(e);
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                string username = row.Cells["Tên tài khoản"].Value?.ToString();
                var isActiveObj = row.Cells["IsActivate"].Value;

                if (string.IsNullOrWhiteSpace(username))
                {
                    row.DefaultCellStyle.BackColor = Color.Orange;
                }
                else if (isActiveObj != null && Convert.ToInt32(isActiveObj) == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                }
            }
        }
    }
}
