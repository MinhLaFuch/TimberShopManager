using System.Data;
using System.Globalization;
using timber_shop_manager.BUS;
using timber_shop_manager.DTO;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmEmployee : Form
    {
        #region Properties
        private readonly EmployeeBUS employeeBUS = new EmployeeBUS();
        private DynamicSearch dynamicSearch = null;
        private bool searchMode = false;
        private EmployeeDTO employeeSelected = null;
        private EmployeeDTO emp;
        public frmEmployee()
        {
            InitializeComponent();
        }

        public frmEmployee(EmployeeDTO emp) : this()
        {
            this.emp = emp;
        }
        #endregion
        #region Support methods
        private void LoadForm()
        {
            ExitSearchMode();
            ClearInput();
            LoadData();
            EnterDefaultMode();
        }

        private void ClearInput()
        {
            txtId.Clear();
            txtName.Clear();
            txtIden.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtSalary.Clear();
            cbRole.SelectedIndex = -1;
            dtpBirthDay.Value = DateTime.Now;
        }
        private void ButtonVisibility(bool featureBtn, bool cellBtn, bool saveBtn, bool cancelBtn)
        {
            btnAdd.Visible = featureBtn;
            btnDel.Visible = cellBtn;
            btnMod.Visible = cellBtn;
            btnViewAttendance.Visible = cellBtn;
            btnSave.Visible = saveBtn;
            btnCancel.Visible = cancelBtn;
        }
        private void EnterDefaultMode()
        {
            pnInfor.Enabled = false;
            EnableInputFields(false);

            ButtonVisibility(true, false, false, false);

            PrepareSearchState(false);
        }

        private void EnterEditMode()
        {
            pnInfor.Enabled = true;
            EnableInputFields(true);
            txtId.Enabled = false;
    
            ButtonVisibility(false, false, true, true);
        }

        private void EnterSearchMode()
        {
            pnInfor.Enabled = true;
            ClearInput();
            EnableInputFields(true);
            dtpBirthDay.Enabled = false;
            txtId.Focus();

            ButtonVisibility(false, false, false, true);

            PrepareSearchState(true);
            SetupDynamicSearch();
        }

        private void PrepareSearchState(bool isSearchMode)
        {
            searchMode = isSearchMode;
            txtId.Enabled = isSearchMode;
        }
        private void EnableInputFields(bool enable)
        {
            txtId.Enabled = enable;
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
            dgv.DataSource = employeeBUS.GetEmployeeList();
            cbRole.DataSource = employeeBUS.GetRoles();
            cbRole.SelectedIndex = -1;
        }
        private void BindSelectedEmployee(int rowIndex)
        {
            ClearInput();

            var row = dgv.Rows[rowIndex];
            txtId.Text = row.Cells["Mã"].Value.ToString();
            txtName.Text = row.Cells["Tên"].Value.ToString();
            txtIden.Text = row.Cells["Số CCCD"].Value.ToString();
            txtPhoneNumber.Text = row.Cells["Số điện thoại"].Value.ToString();
            txtAddress.Text = row.Cells["Nơi ở"].Value.ToString();
            cbRole.Text = row.Cells["Chức danh"].Value.ToString();
            dtpBirthDay.Value = DateTime.ParseExact(row.Cells["Ngày sinh"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            txtSalary.Text = row.Cells["Lương"].Value.ToString();

            employeeSelected = new EmployeeDTO(
                txtId.Text,
                txtName.Text,
                txtIden.Text,
                txtAddress.Text,
                dtpBirthDay.Value,
                Convert.ToDouble(txtSalary.Text),
                txtPhoneNumber.Text,
                cbRole.Text
            );
        }
        private void SetupDynamicSearch()
        {
            if (dynamicSearch != null)
            {
                dynamicSearch.Enable();
                return;
            }
            var controls = new List<Control> { txtId, txtName, txtIden, txtPhoneNumber, txtAddress, cbRole };
            var columnMappings = new Dictionary<string, string>
            {
                { "txtId", "Mã" },
                { "txtName", "Tên" },
                { "txtIden", "Số CCCD" },
                { "txtPhoneNumber", "Số điện thoại" },
                { "txtAddress", "Nơi ở" },
                { "cbRole", "Chức danh" }
            };

            dynamicSearch = new DynamicSearch(controls, columnMappings, employeeBUS.GetEmployeeList, dgv);
            dynamicSearch.Enable();
        }
        private void ExitSearchMode()
        {
            if (!searchMode) return;

            searchMode = false;
            dynamicSearch?.Disable();
            LoadData();
            txtId.Enabled = false;
        }
        #endregion
        #region Load event
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion
        #region Button click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExitSearchMode();
            ClearInput();
            EnterEditMode();
            LoadData();

            string currentCode = Program.GenerateNextCode(employeeBUS.GetLastEmployeeId(), "E", 4);
            txtId.Text = currentCode;
            txtName.Focus();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (employeeSelected == null) return;

            var confirm = MessageBox.Show("Bạn chắc chắn muốn xoá nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                employeeBUS.DeleteEmployee(employeeSelected.Id);
                LoadForm();
            }
        }
        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            frmAttendance frmAttendance = new frmAttendance(employeeSelected, true);
            frmAttendance.ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = new EmployeeDTO(
                    txtId.Text,
                    txtName.Text,
                    txtIden.Text,
                    txtAddress.Text,
                    dtpBirthDay.Value,
                    Convert.ToDouble(txtSalary.Text),
                    txtPhoneNumber.Text,
                    cbRole.Text
                );

                employeeBUS.AddOrUpdateEmployee(emp);
                MessageBox.Show("Lưu thành công!");
                LoadForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExitSearchMode();
            LoadForm();
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            if (employeeSelected != null)
                EnterEditMode();
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
        #endregion
        #region KeyPress event
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e) => InputValidator.CheckInputIsDigit(e);
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e) => InputValidator.CheckInputIsDigit(e);
        private void txtName_KeyPress(object sender, KeyPressEventArgs e) => InputValidator.CheckInputIsLetter(e);
        private void txtIden_KeyPress(object sender, KeyPressEventArgs e) => InputValidator.CheckInputIsDigit(e);
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

            ExitSearchMode();
            BindSelectedEmployee(e.RowIndex);
            ButtonVisibility(true, true, false, false);
        }
        #endregion
    }
}
