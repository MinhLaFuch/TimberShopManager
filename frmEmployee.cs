using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmEmployee : Form
    {
        #region Properties
        private static DatabaseHelper dbHelper = new DatabaseHelper();
        public frmEmployee()
        {
            InitializeComponent();
        }
        #endregion
        #region Support Method
        private void loadForm()
        {
            txtID.ReadOnly = true;
            clearTextBox();
            dgvEmployee.DataSource = loadData();
            btnEnabler(false, true);
            gbAccInfo.Enabled = false;
            searchEventEnable(false);
            btnAdd.Enabled = true;
            btnSearch.Enabled = true;
        }
        private DataTable loadData()
        {
            // Load data from database to DataGridView
            string query = "SELECT EmployeeID, Name, IdentificationNumber, PhoneNumber, Address, Role, DateOfBirth, Salary FROM Employee";
            DataTable dt = dbHelper.ExecuteQuery(query);
            return dt;
        }
        private void clearTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            txtIden.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
            txtSalary.Clear();
            cbRole.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
        }
        private void btnEnabler(bool feat_btn, bool init_btn)
        {
            btnDel.Enabled = btnMod.Enabled = btnViewWorkHour.Enabled = feat_btn;
            btnAdd.Enabled = btnSearch.Enabled = init_btn;
        }
        private string idGenerator()
        {
            string query = "SELECT EmployeeID FROM Employee ORDER BY EmployeeId DESC";
            DataTable dt = dbHelper.ExecuteQuery(query);
            string newId = "0001";
            if (dt.Rows.Count > 0)
            {
                // Extracting maxID
                string maxId = dt.Rows[0]["EmployeeId"].ToString();
                int id = int.Parse(maxId.Substring(1, maxId.Length - 1)) + 1;
                newId = "0000" + id.ToString();
                newId = newId.Substring(newId.Length - 4, 4);
            }
            return "E" + newId;
        }
        private void searchEventEnable(bool b)
        {
            if (b)
            {
                txtID.TextChanged += txtID_TextChanged;
                txtName.TextChanged += txtName_TextChanged;
                txtIden.TextChanged += txtIden_TextChanged;
                txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
                txtAddress.TextChanged += txtAddress_TextChanged;
                dtpDOB.ValueChanged += dtpDOB_ValueChanged;
                cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
                txtSalary.TextChanged += txtSalary_TextChanged;
            } else
            {
                txtID.TextChanged -= txtID_TextChanged;
                txtName.TextChanged -= txtName_TextChanged;
                txtIden.TextChanged -= txtIden_TextChanged;
                txtPhoneNumber.TextChanged -= txtPhoneNumber_TextChanged;
                txtAddress.TextChanged -= txtAddress_TextChanged;
                dtpDOB.ValueChanged -= dtpDOB_ValueChanged;
                cbRole.SelectedIndexChanged -= cbRole_SelectedIndexChanged;
                txtSalary.TextChanged -= txtSalary_TextChanged;
            }
        }
        // Search incomplete
        private void suggestEmployee()
        {
            // Kiểm tra xem có TextBox nào trống không
            bool isTextBoxesEmpty = string.IsNullOrEmpty(txtID.Text)
                                    && string.IsNullOrEmpty(txtName.Text)
                                    && string.IsNullOrEmpty(txtIden.Text)
                                    && string.IsNullOrEmpty(txtPhoneNumber.Text)
                                    && string.IsNullOrEmpty(txtAddress.Text)
                                    && string.IsNullOrEmpty(cbRole.Text)
                                    && string.IsNullOrEmpty(txtSalary.Text);

            // Chỉ search khi có ít nhất một TextBox có dữ liệu
            if (!isTextBoxesEmpty)
            {
                // Tạo DataView để lọc dữ liệu từ DataGridView
                DataView dv = new DataView();

                // Tạo một danh sách điều kiện lọc dựa trên các TextBox có dữ liệu
                List<string> filters = new List<string>();

                if (!string.IsNullOrEmpty(txtID.Text))
                {
                    filters.Add($"EmployeeID LIKE '%{txtID.Text}%'");
                }
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    filters.Add($"Name LIKE '%{txtName.Text}%'");
                }
                if (!string.IsNullOrEmpty(txtIden.Text))
                {
                    filters.Add($"IdentificationNumber LIKE '%{txtIden.Text}%'");
                }
                if (!string.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    filters.Add($"Name LIKE '%{txtPhoneNumber.Text}%'");
                }
                if (!string.IsNullOrEmpty(txtAddress.Text))
                {
                    filters.Add($"Address LIKE '%{txtAddress.Text}%'");
                }
                if (!string.IsNullOrEmpty(cbRole.Text))
                {
                    filters.Add($"Role LIKE '%{cbRole.Text}%'");
                }

                // Nếu có điều kiện lọc, kết nối chúng bằng OR
                if (filters.Count > 0)
                {
                    dv.RowFilter = string.Join(" OR ", filters);
                }

                // Gán DataSource cho DataGridView
                dgvEmployee.DataSource = dv;
            }
        }
        public static void CheckInputIsDigit(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // Ngừng sự kiện nếu ký tự không hợp lệ
            }
        }
        public static void CheckInputIsLetter(KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')) && c != (char)8)
            {
                e.Handled = true;
            }
        }
        #endregion
        #region Event
        #region Form Load
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        #endregion
        #region Click Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbAccInfo.Enabled = true;
            clearTextBox();
            txtName.Focus();
            btnEnabler(false, false);
            btnAdd.Enabled = false;
            btnSearch.Enabled = false;
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Employee WHERE EmployeeId = @ID";
            // Get a confirmation from the user
            DialogResult confirmation = MessageBox.Show("Are you sure you want to delete this employee?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                dbHelper.ExecuteNonQuery(query, new SqlParameter("@ID", txtID.Text));
            }

            // Reload form
            loadForm();
        }
        private void btnViewWorkHour_Click(object sender, EventArgs e)
        {
            frmAttendance frmAttendance = new frmAttendance();
            frmAttendance.EmployeeId = txtID.Text;
            frmAttendance.EmployeeName = txtName.Text;
            frmAttendance.ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isAdding = string.IsNullOrEmpty(txtID.Text);
            string query = "";
            if (isAdding)
            {
                query = "INSERT INTO Employee (EmployeeId, Name, IdentificationNumber, Address, DateOfBirth, Salary, Role, PhoneNumber)" +
                    "VALUES (@id, @name, @iden, @address, @dob, @salary, @role, @phoneNumber)";
                dbHelper.ExecuteNonQuery(query, new SqlParameter("@id", idGenerator()),
                    new SqlParameter("@name", txtName.Text),
                    new SqlParameter("@iden", txtIden.Text),
                    new SqlParameter("@address", txtAddress.Text),
                    new SqlParameter("@dob", dtpDOB.Value),
                    new SqlParameter("@salary", txtSalary.Text),
                    new SqlParameter("@role", cbRole.SelectedItem.ToString()),
                    new SqlParameter("@phoneNumber", txtPhoneNumber.Text));
            }
            else
            {
                query = "UPDATE Employee SET Salary = @salary, Role = @role WHERE EmployeeId = @id";
                dbHelper.ExecuteNonQuery(query,
                    new SqlParameter("@id", txtID.Text),
                    new SqlParameter("@salary", txtSalary.Text),
                    new SqlParameter("@role", cbRole.SelectedItem.ToString()));
            }
            // Reload form
            loadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadForm();
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            // Can only access salary and role info
            gbAccInfo.Enabled = true;
            txtName.Enabled = false;
            txtIden.Enabled = false;
            txtAddress.Enabled = false;
            txtPhoneNumber.Enabled = false;
            dtpDOB.Enabled = false;
            cbRole.Focus();
            btnEnabler(false, false);
            btnAdd.Enabled = false;
            btnSearch.Enabled = false;
        }
        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployee.Rows.Count > 0)
            {
                int rowIndex = e.RowIndex;

                // Fill all info to groupbox
                txtID.Text = dgvEmployee.Rows[rowIndex].Cells["EmployeeId"].Value.ToString();
                txtName.Text = dgvEmployee.Rows[rowIndex].Cells["Name"].Value.ToString();
                txtIden.Text = dgvEmployee.Rows[rowIndex].Cells["IdentificationNumber"].Value.ToString();
                txtAddress.Text = dgvEmployee.Rows[rowIndex].Cells["Address"].Value.ToString();
                cbRole.SelectedItem = dgvEmployee.Rows[rowIndex].Cells["Role"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(dgvEmployee.Rows[rowIndex].Cells["DateOfBirth"].Value);
                txtSalary.Text = dgvEmployee.Rows[rowIndex].Cells["Salary"].Value.ToString();
                txtPhoneNumber.Text = dgvEmployee.Rows[rowIndex].Cells["PhoneNumber"].Value.ToString();

                // Enable button
                btnEnabler(true, true);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            gbAccInfo.Enabled = true;
            txtID.ReadOnly = false;
            btnSave.Enabled = false;
            txtID.Focus();
            btnEnabler(false, false);
            searchEventEnable(true);
        }

        #endregion
        #region Key Press
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmployee.CheckInputIsDigit(e);
        }
        private void txtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmployee.CheckInputIsDigit(e);
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmployee.CheckInputIsLetter(e);
        }
        private void txtIden_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmEmployee.CheckInputIsDigit(e);
        }
        #endregion
        #region Search Text Changed
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            suggestEmployee();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            suggestEmployee();
        }
        private void txtIden_TextChanged(object sender, EventArgs e)
        {
            suggestEmployee();
        }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            suggestEmployee();
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            suggestEmployee();
        }
        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            suggestEmployee();
        }
        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            suggestEmployee();
        }
        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            suggestEmployee();
        }
        #endregion
        #endregion
    }
}
