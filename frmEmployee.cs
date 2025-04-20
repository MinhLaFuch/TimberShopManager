using System.Data;
using System.Globalization;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmEmployee : Form
    {
        private DynamicSearch dynamicSearch = null;
        private bool searchMode = false;
        private Employee employeeSelected = null;

        private static DatabaseHelper dbHelper = new DatabaseHelper();
        private Account account = null;
        public frmEmployee()
        {
            InitializeComponent();
        }

        public frmEmployee(Account account) : this()
        {
            this.account = account;
        }
        private void LoadForm()
        {
            ExitSearchMode();
            ClearTextBox();
            LoadData();
            EnterDefaultMode();
        }

        private void EnterDefaultMode()
        {
            pnInfor.Enabled = false;
            EnableInputFields(false);

            btnAdd.Enabled = true;
            btnSearch.Enabled = true;
            btnSave.Enabled = false;
            btnDel.Enabled = false;
            btnMod.Enabled = false;
            btnViewAttendance.Enabled = false;

            PrepareSearchState(false);
        }

        private void EnterEditMode()
        {
            pnInfor.Enabled = true;
            EnableInputFields(true);
            txtId.Enabled = false;

            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnSearch.Enabled = false;
            btnDel.Enabled = false;
            btnMod.Enabled = false;
            btnViewAttendance.Enabled = false;
        }

        private void EnterSearchMode()
        {
            pnInfor.Enabled = true;
            ClearTextBox();
            EnableInputFields(true);
            dtpBirthDay.Enabled = false;
            txtId.Focus();

            btnSave.Enabled = false;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnMod.Enabled = false;
            btnViewAttendance.Enabled = false;

            PrepareSearchState(true);
            SetupDynamicSearch();
        }

        private void PrepareSearchState(bool isSearchMode)
        {
            searchMode = isSearchMode;
            btnSearch.Text = isSearchMode ? "Huỷ tìm" : "Tìm kiếm";
            txtId.Enabled = isSearchMode;
        }

        private void EnableInputFields(bool enable)
        {
            txtName.Enabled = enable;
            txtIden.Enabled = enable;
            txtPhoneNumber.Enabled = enable;
            txtAddress.Enabled = enable;
            dtpBirthDay.Enabled = enable;
            cbRole.Enabled = enable;
            txtSalary.Enabled = enable;
        }

        private void LoadData()
        {
            dgv.DataSource = LoadDataGridView();
            cbRole.DataSource = LoadComboBox();
            cbRole.SelectedIndex = -1;
        }

        private List<string> LoadComboBox()
        {
            string query = "SELECT DISTINCT Role FROM Employee ORDER BY Role";
            return dbHelper.GetDataForComboBox(query, "Role");
        }

        private DataTable LoadDataGridView()
        {
            string query =
                "SELECT " +
                    "Id AS 'Mã', " +
                    "Name AS 'Tên', " +
                    "IdentificationNumber AS 'Số CCCD', " +
                    "PhoneNumber AS 'Số điện thoại', " +
                    "Address AS 'Nơi ở', " +
                    "Role AS 'Chức danh', " +
                    "CONVERT(varchar, Birthday, 103) AS 'Ngày sinh', " +
                    "Salary AS 'Lương'" +
                "FROM Employee WHERE IsDeleted = 0 ORDER BY Id";
            return dbHelper.ExecuteQuery(query);
        }
        private void ClearTextBox()
        {
            txtId.Clear();
            txtName.Clear();
            txtIden.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtSalary.Clear();
            cbRole.SelectedIndex = -1;
            dtpBirthDay.Value = DateTime.Now;
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExitSearchMode();
            ClearTextBox();
            EnterEditMode();
            LoadData();

            string query = "SELECT MAX(Id) FROM Employee";
            string currentCode = Convert.ToString(dbHelper.ExecuteScalar(query));
            txtId.Text = Program.GenerateNextCode(currentCode, Employee.PREFIX, Employee.CODE_LENGTH);

            txtName.Focus();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Bạn có chắc chắn xóa nhân viên này không?\nHành động này sẽ không thể khôi phục",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                Employee.delete(employeeSelected);
                LoadForm();
            }
        }
        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            frmAttendance frmAttendance = new frmAttendance(account);
            frmAttendance.ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var inputMap = new Dictionary<Control, Label>
            {
                { txtId, lbId }, { txtName, lbName }, { txtIden, lbIden },
                { txtPhoneNumber, lbPhoneNumber }, { txtAddress, lbAdress },
                { cbRole, lbRole }, { txtSalary, lbSalary }
            };

            if (!InputValidator.ValidateNotEmpty(inputMap)) return;
            if (!Employee.IsLegalWorkingAge(dtpBirthDay.Value)) return;

            var emp = new Employee(
                txtId.Text,
                txtName.Text,
                txtIden.Text,
                txtAddress.Text,
                dtpBirthDay.Value,
                txtSalary.Text,
                txtPhoneNumber.Text,
                cbRole.Text);

            Employee.add(emp);
            LoadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExitSearchMode();
            LoadForm();
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            if (employeeSelected != null)
            {
                EnterEditMode();
            }
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!searchMode)
            {
                EnterSearchMode();
            }
            else
                LoadForm();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e) => InputValidator.CheckInputIsDigit(e);
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e) => InputValidator.CheckInputIsDigit(e);
        private void txtName_KeyPress(object sender, KeyPressEventArgs e) => InputValidator.CheckInputIsLetter(e);
        private void txtIden_KeyPress(object sender, KeyPressEventArgs e) => InputValidator.CheckInputIsDigit(e);
        

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgv.Rows[e.RowIndex].Cells["Mã"].Value == null)
            {
                ExitSearchMode();
                EnterDefaultMode();
                return;
            }

            ExitSearchMode();
            BindSelectedEmployee(e.RowIndex);
            EnableSelectionButtons();
        }

        private void BindSelectedEmployee(int rowIndex)
        {
            ClearTextBox();

            var row = dgv.Rows[rowIndex];
            txtId.Text = row.Cells["Mã"].Value?.ToString();
            txtName.Text = row.Cells["Tên"].Value?.ToString();
            txtIden.Text = row.Cells["Số CCCD"].Value?.ToString();
            txtPhoneNumber.Text = row.Cells["Số điện thoại"].Value?.ToString();
            cbRole.Text = row.Cells["Chức danh"].Value?.ToString();
            txtAddress.Text = row.Cells["Nơi ở"].Value?.ToString();
            dtpBirthDay.Value = DateTime.ParseExact(row.Cells["Ngày sinh"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            txtSalary.Text = row.Cells["Lương"].Value?.ToString();

            employeeSelected = new Employee(txtId.Text, txtName.Text, txtIden.Text, txtAddress.Text, dtpBirthDay.Value, txtSalary.Text, txtPhoneNumber.Text, cbRole.Text);
        }

        private void EnableSelectionButtons()
        {
            EnterDefaultMode(); // thiết lập cơ bản
            btnDel.Enabled = true;
            btnMod.Enabled = true;
            btnViewAttendance.Enabled = true;
        }

        private void SetupDynamicSearch()
        {
            if (dynamicSearch != null)
            {
                dynamicSearch.Enable();
                return;
            }

            List<Control> searchControls = new() { txtId, txtName, txtIden, txtPhoneNumber, txtAddress, cbRole };
            Dictionary<string, string> columnMappings = new()
            {
                { "txtId", "Mã" },
                { "txtName", "Tên" },
                { "txtIden", "Số CCCD" },
                { "txtPhoneNumber", "Số điện thoại" },
                { "txtAddress", "Nơi ở" },
                { "cbRole", "Chức danh" }
            };

            dynamicSearch = new DynamicSearch(searchControls, columnMappings, LoadDataGridView, dgv);
            dynamicSearch.Enable();
        }

        private void ExitSearchMode()
        {
            if (!searchMode) return;

            searchMode = false;
            btnSearch.Text = "Tìm kiếm";

            dynamicSearch?.Disable();
            dgv.DataSource = LoadDataGridView();
            txtId.Enabled = false;
        }

    }
}
