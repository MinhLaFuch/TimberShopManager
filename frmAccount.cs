using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmAccount : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public frmAccount()
        {
            InitializeComponent();
        }
        #endregion
        #region Support methods
        private void loadForm()
        {
            pnInfo.Enabled = false;
            txtPassword.ReadOnly = true;
            clearTextBox();
            pnButtonEnabler(true, false);
            featureButtonEnabler(true, false);
            dgv.DataSource = loadData();
            searchEventEnabler(false);
        }
        private DataTable loadData()
        {
            // Load data from database
            string query = "SELECT emp.EmployeeId AS 'Mã nhân viên', emp.Name AS 'Tên', " +
                          "acc.Username AS 'Tên tài khoản', acc.Password AS 'Mật khẩu', " +
                          "emp.Role AS 'Chức vụ' FROM Account acc " +
                          "JOIN Employee emp ON acc.EmployeeId = emp.EmployeeId " +
                          "WHERE emp.EmployeeId NOT IN (SELECT EmployeeId FROM LockedAccount)";
            DataTable dt = dbHelper.ExecuteQuery(query);
            return dt;
        }
        private void clearTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cbRole.SelectedIndex = -1;
        }
        private void pnButtonEnabler(bool featBtn, bool infoBtn)
        {
            pnFeatureButton.Visible = featBtn;
            pnInfoButton.Visible = infoBtn;
        }
        private void featureButtonEnabler(bool nonCellBtn, bool cellBtn)
        {
            btnAdd.Visible = btnSearch.Visible = nonCellBtn;
            btnLock.Visible = cellBtn;
        }
        private void searchEventEnabler(bool b)
        {
            if (b)
            {
                txtID.TextChanged += txtID_TextChanged;
                txtName.TextChanged += txtName_TextChanged;
                txtUsername.TextChanged += txtUsername_TextChanged;
                cbRole.SelectedIndexChanged += cbRole_SelectedValueChanged;
            }
            else
            {
                txtID.TextChanged -= txtID_TextChanged;
                txtName.TextChanged -= txtName_TextChanged;
                txtUsername.TextChanged -= txtUsername_TextChanged;
                cbRole.SelectedIndexChanged -= cbRole_SelectedValueChanged;
            }
        }
        // I need search method
        private void suggest()
        {

        }
        #endregion
        #region Events
        #region Load
        private void frmAccount_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        #endregion
        #region Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmChangePW frmChangePW = new frmChangePW();
            this.Hide();
            frmChangePW.ShowDialog();
        }
        // Have not done the lock in database
        private void btnLock_Click(object sender, EventArgs e)
        {
            string query = @"
                INSERT INTO LockedAccount (EmployeeId, Username, Password)
                SELECT acc.EmployeeId, acc.Username, acc.Password
                FROM Account acc
                WHERE acc.EmployeeId IN (SELECT EmployeeId FROM DeletedEmployee);

                DELETE FROM Account
                WHERE EmployeeId IN (SELECT EmployeeId FROM DeletedEmployee);
            ";

            try
            {
                int rowsAffected = dbHelper.ExecuteNonQuery(query);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Tài khoản đã khóa thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv.DataSource = loadData(); // Refresh the data grid view
                }
                else
                {
                    MessageBox.Show("Nhân viên hiện vẫn còn trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadForm();
        }
        // Not done yet
        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnInfo.Enabled = true;
            clearTextBox();
            txtID.Focus();
            searchEventEnabler(true);
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                int rowIndex = e.RowIndex;
                txtID.Text = dgv.Rows[rowIndex].Cells["Mã nhân viên"].Value.ToString();
                txtName.Text = dgv.Rows[rowIndex].Cells["Tên"].Value.ToString();
                txtUsername.Text = dgv.Rows[rowIndex].Cells["Tên tài khoản"].Value.ToString();
                txtPassword.Text = dgv.Rows[rowIndex].Cells["Mật khẩu"].Value.ToString();
                cbRole.Text = dgv.Rows[rowIndex].Cells["Chức vụ"].Value.ToString();

                featureButtonEnabler(true, true);
                // Need to paint the row in green if the employee is deleted to remind the user to lock the account
            }
        }
        #endregion
        #region Text Change
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            suggest();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            suggest();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            suggest();
        }
        private void cbRole_SelectedValueChanged(object sender, EventArgs e)
        {
            suggest();
        }
        #endregion
        #region Key Press
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CheckInputIsLetter(e);
        }
        #endregion
        #endregion
    }
}
