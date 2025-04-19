using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;
using static iTextSharp.text.pdf.PdfDocument;

namespace timber_shop_manager
{
    public partial class frmEmployee : Form
    {
        private DynamicSearch dynamicSearch = null;
        private bool searchMode = false;
        private Employee employeeSelected = null;

        #region Properties
        private static DatabaseHelper dbHelper = new DatabaseHelper();
        private Account account;
        public frmEmployee()
        {
            InitializeComponent();
        }

        public frmEmployee(Account account) : this()
        {
            this.account = account;
        }
        #endregion
        #region Support Method
        private void LoadForm()
        {
            pnInfor.Enabled = false;
            btnDel.Enabled = btnMod.Enabled = btnSave.Enabled = false;
            ClearTextBox();
            LoadData();
            txtId.Enabled = false;
            dynamicSearch?.Disable();
            txtId.Enabled = searchMode;
        }
        private void loadFormBasedOnRole()
        {
            bool authority = account.verifyPermission() == Employee.Role.MANAGER;
            btnAdd.Visible = btnDel.Visible = btnMod.Visible = btnViewAttendance.Visible = authority;
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
        private void btnEnabler(bool featBtn, bool initBtn)
        {
            btnDel.Enabled = btnMod.Enabled = btnViewAttendance.Enabled = featBtn;
            btnAdd.Enabled = btnSearch.Enabled = initBtn;
        }

        #endregion
        #region Event
        #region Load
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        #endregion
        #region Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnInfor.Enabled = true;
            ClearTextBox();
            txtName.Focus();
            btnSave.Enabled = true;

            btnDel.Enabled = btnMod.Enabled = btnViewAttendance.Enabled = false;
            txtName.Enabled = txtIden.Enabled = txtPhoneNumber.Enabled = txtAddress.Enabled = dtpBirthDay.Enabled = cbRole.Enabled = txtSalary.Enabled = true;

            txtId.Enabled = false;
            string query = "SELECT MAX(Id) FROM Employee";
            string currentCode = Convert.ToString(dbHelper.ExecuteScalar(query));

            txtId.Text = Program.GenerateNextCode(currentCode, Employee.PREFIX, Employee.CODE_LENGTH);
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Hành động này sẽ không thể khôi phục\nBạn có chắc chắn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                Employee.delete(employeeSelected);
                LoadForm();
            }
        }
        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            frmAttendance frmAttendance = new frmAttendance();
            frmAttendance.EmployeeId = txtId.Text;
            frmAttendance.EmployeeName = txtName.Text;
            frmAttendance.ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(txtId.Text, txtName.Text, txtIden.Text, txtAddress.Text, dtpBirthDay.Value, txtSalary.Text, txtPhoneNumber.Text, cbRole.Text);
            Employee.add(emp);
            LoadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            // Can only access salary and role info
            gbInfo.Enabled = true;
            txtName.Enabled = false;
            txtIden.Enabled = false;
            txtAddress.Enabled = false;
            txtPhoneNumber.Enabled = false;
            dtpBirthDay.Enabled = false;
            cbRole.Focus();
            btnEnabler(false, false);
        }
        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            if (!searchMode)
            {
                pnInfor.Enabled = true;
                txtId.Focus();

                btnAdd.Enabled = false;
                btnDel.Enabled = false;
                btnMod.Enabled = false;
                btnViewAttendance.Enabled = false;
                dtpBirthDay.Enabled = false;

                btnSearch.Text = "Huỷ tìm";

                if (dynamicSearch == null)
                {
                    List<Control> searchControls = new List<Control>() { txtId, txtName, txtIden, txtPhoneNumber, txtAddress, cbRole };
                    Dictionary<string, string> columnMappings = new Dictionary<string, string>()
                        {
                            {"txtId", "Mã" },
                            {"txtName", "Tên" },
                            {"txtIden", "Số CCCD" },
                            {"txtPhoneNumber", "Số điện thoại" },
                            {"txtAddress", "Nơi ở" },
                            {"cbRole", "Chức danh" },
                        };
                    dynamicSearch = new DynamicSearch(searchControls, columnMappings, LoadDataGridView, dgv);
                }
                dynamicSearch?.Enable();

                searchMode = true;
            }
            else
            {
                btnSearch.Text = "Tìm kiếm";
                btnAdd.Enabled = true;
                btnDel.Enabled = true;
                btnMod.Enabled = true;
                btnViewAttendance.Enabled = true;
                dtpBirthDay.Enabled = true;

                dgv.DataSource = LoadDataGridView();

                dynamicSearch?.Disable();
                searchMode = false;
            }
            txtId.Enabled = searchMode;
            btnSave.Enabled = !searchMode;
        }

        #endregion
        #region Key Press
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CheckInputIsDigit(e);
        }
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CheckInputIsDigit(e);
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CheckInputIsLetter(e);
        }
        private void txtIden_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CheckInputIsDigit(e);
        }
        #endregion

        #endregion

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearTextBox();
            btnDel.Enabled = btnMod.Enabled = btnSave.Enabled = true;
            txtId.Enabled = txtName.Enabled = txtIden.Enabled = txtPhoneNumber.Enabled = txtAddress.Enabled = dtpBirthDay.Enabled = cbRole.Enabled = txtSalary.Enabled = false;
            if (dgv.Rows.Count > 0)
            {
                int rowIndex = e.RowIndex;
                txtId.Text = dgv.Rows[rowIndex].Cells["Mã"].Value.ToString();
                txtName.Text = dgv.Rows[rowIndex].Cells["Tên"].Value.ToString();
                txtIden.Text = dgv.Rows[rowIndex].Cells["Số CCCD"].Value.ToString();
                txtPhoneNumber.Text = dgv.Rows[rowIndex].Cells["Số điện thoại"].Value.ToString(); 
                cbRole.Text = dgv.Rows[rowIndex].Cells["Chức danh"].Value.ToString();
                txtAddress.Text = dgv.Rows[rowIndex].Cells["Nơi ở"].Value.ToString();
                dtpBirthDay.Value = DateTime.ParseExact(dgv.Rows[rowIndex].Cells["Ngày sinh"].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                cbRole.Text = dgv.Rows[rowIndex].Cells["Chức danh"].Value.ToString();
                txtSalary.Text = dgv.Rows[rowIndex].Cells["Lương"].Value.ToString();

                employeeSelected = new Employee(txtId.Text, txtName.Text, txtIden.Text, txtAddress.Text, dtpBirthDay.Value, txtSalary.Text, txtPhoneNumber.Text, cbRole.Text);
            }
        }
    }
}
