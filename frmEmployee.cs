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
            clearTextBox();
            loadData();
            btnEnabler(false);
            gbAccInfo.Enabled = false;
        }
        private void loadData()
        {
            // Load data from database to DataGridView
            string query = "SELECT * FROM Employee";
            DataTable dt = dbHelper.ExecuteQuery(query);
            dgvEmployee.DataSource = dt;
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
        private void btnEnabler(bool b)
        {
            btnDel.Enabled = b;
            btnViewWorkHour.Enabled = b;
            btnMod.Enabled = b;
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
            btnEnabler(false);
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
            frmWorkHour frmWorkHour = new frmWorkHour();
            frmWorkHour.EmployeeId = txtID.Text;
            frmWorkHour.ShowDialog();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isAdding = string.IsNullOrEmpty(txtID.Text);
            string query = "";
            if (isAdding)
            {
                query = "INSERT INTO Employee (EmployeeId, Name, IdentificationNumber, Address, DateOfBirth, Salary, Role, PhoneNumber)" +
                    "VALUES(@id, @name, @iden, @address, @dob, @salary, @role, @phoneNumber";
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
            btnEnabler(false);
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
                btnEnabler(true);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            gbAccInfo.Enabled = true;
            txtID.ReadOnly = false;
            txtID.Focus();
            btnEnabler(false);
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
        #endregion


    }
}
