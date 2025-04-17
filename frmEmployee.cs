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
            dgv.DataSource = loadData();
            btnEnabler(false, true);
            gbInfo.Enabled = false;
            searchEventEnabler(false);
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
            dtpDOBFrom.Value = DateTime.Now;
        }
        private void btnEnabler(bool featBtn, bool initBtn)
        {
            btnDel.Enabled = btnMod.Enabled = btnViewAttendance.Enabled = featBtn;
            btnAdd.Enabled = btnSearch.Enabled = initBtn;
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
        private void searchEventEnabler(bool b)
        {
            if (b)
            {
                txtID.TextChanged += txtID_TextChanged;
                txtName.TextChanged += txtName_TextChanged;
                txtIden.TextChanged += txtIden_TextChanged;
                txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
                txtAddress.TextChanged += txtAddress_TextChanged;
                dtpDOBFrom.ValueChanged += dtpDOB_ValueChanged;
                cbRole.SelectedIndexChanged += cbRole_SelectedIndexChanged;
                txtSalary.TextChanged += txtSalary_TextChanged;
                lbFromTo.Visible = true;
                dtpDOBTo.Visible = true;
            }
            else
            {
                txtID.TextChanged -= txtID_TextChanged;
                txtName.TextChanged -= txtName_TextChanged;
                txtIden.TextChanged -= txtIden_TextChanged;
                txtPhoneNumber.TextChanged -= txtPhoneNumber_TextChanged;
                txtAddress.TextChanged -= txtAddress_TextChanged;
                dtpDOBFrom.ValueChanged -= dtpDOB_ValueChanged;
                cbRole.SelectedIndexChanged -= cbRole_SelectedIndexChanged;
                txtSalary.TextChanged -= txtSalary_TextChanged;
                lbFromTo.Visible = false;
                dtpDOBTo.Visible = false;
            }
        }
        // Search incomplete
        private void suggest()
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
                dgv.DataSource = dv;
            }
        }
        #endregion
        #region Event
        #region Load
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        #endregion
        #region Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbInfo.Enabled = true;
            clearTextBox();
            txtName.Focus();
            btnEnabler(false, false);
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            string insertDeletedQuery = "INSERT INTO DeletedEmployee (categoryID, categoryName, Description) SELECT categoryID, categoryName, Description FROM category WHERE categoryID = @ID;";
            string deleteQuery = "DELETE FROM category WHERE categoryID = @ID;";

            // Get a confirmation from the user  
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn xóa danh mục này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                DataTable dt = dbHelper.ExecuteQuery("SELECT * FROM Product WHERE categoryID = @ID", new SqlParameter("@ID", txtID.Text));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Không thể xóa danh mục này vì nó đang được sử dụng trong sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Insert into Deletedcategory table  
                    dbHelper.ExecuteNonQuery(insertDeletedQuery, new SqlParameter("@ID", txtID.Text));

                    // Delete from category table  
                    dbHelper.ExecuteNonQuery(deleteQuery, new SqlParameter("@ID", txtID.Text));
                }
            }
            // Reload form  
            loadForm();
        }
        private void btnViewAttendance_Click(object sender, EventArgs e)
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
                    new SqlParameter("@dob", dtpDOBFrom.Value),
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
            gbInfo.Enabled = true;
            txtName.Enabled = false;
            txtIden.Enabled = false;
            txtAddress.Enabled = false;
            txtPhoneNumber.Enabled = false;
            dtpDOBFrom.Enabled = false;
            cbRole.Focus();
            btnEnabler(false, false);
        }
        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                int rowIndex = e.RowIndex;

                // Fill all info to groupbox
                txtID.Text = dgv.Rows[rowIndex].Cells["EmployeeId"].Value.ToString();
                txtName.Text = dgv.Rows[rowIndex].Cells["Name"].Value.ToString();
                txtIden.Text = dgv.Rows[rowIndex].Cells["IdentificationNumber"].Value.ToString();
                txtAddress.Text = dgv.Rows[rowIndex].Cells["Address"].Value.ToString();
                cbRole.SelectedItem = dgv.Rows[rowIndex].Cells["Role"].Value.ToString();
                dtpDOBFrom.Value = Convert.ToDateTime(dgv.Rows[rowIndex].Cells["DateOfBirth"].Value);
                txtSalary.Text = dgv.Rows[rowIndex].Cells["Salary"].Value.ToString();
                txtPhoneNumber.Text = dgv.Rows[rowIndex].Cells["PhoneNumber"].Value.ToString();

                // Enable button
                btnEnabler(true, true);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            gbInfo.Enabled = true;
            txtID.ReadOnly = false;
            btnSave.Enabled = false;
            txtID.Focus();
            btnEnabler(false, false);
            searchEventEnabler(true);
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
        #region Text Changed
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            suggest();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            suggest();
        }
        private void txtIden_TextChanged(object sender, EventArgs e)
        {
            suggest();
        }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            suggest();
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            suggest();
        }
        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            suggest();
        }
        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            suggest();
        }
        private void txtSalary_TextChanged(object sender, EventArgs e)
        {
            suggest();
        }
        #endregion
        #endregion

        private void txtName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtIden_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPhoneNumber_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
