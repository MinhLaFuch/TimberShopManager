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
        private Account account = null;
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public frmAccount()
        {
            InitializeComponent();
        }
        public frmAccount(Account acc) : this()
        {
            this.account = acc;
        }
        #endregion
        #region Support methods
        private void loadForm()
        {
            loadFeatureBasedOnRole();
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
                          "WHERE emp.EmployeeId NOT IN (SELECT EmployeeId FROM LockedAccount)" +
                          "ORDER BY emp.EmployeeId ASC";
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
        //
        private void loadFeatureBasedOnRole()
        {
            bool isAdmin = account.verifyPermission() == Employee.Role.ADMINISTRATOR;
            btnAdd.Visible = btnLock.Visible = isAdmin;
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
        private void btnLock_Click(object sender, EventArgs e)
        {
            string insertDeletedQuery = "INSERT INTO LockedAccount (EmployeeId, Username, Password) SELECT CatagoryID, CatagoryName, Description FROM Catagory WHERE CatagoryID = @ID;";
            string deleteQuery = "DELETE FROM Account WHERE EmployeeId = @ID;";

            // Get a confirmation from the user  
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn khoá tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                DataTable dt = dbHelper.ExecuteQuery("SELECT * FROM Employee WHERE EmployeeId = @ID", new SqlParameter("@ID", txtID.Text));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Không thể khóa tài khoản này vì nhân viên vẫn còn trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Insert into DeletedCatagory table  
                    dbHelper.ExecuteNonQuery(insertDeletedQuery, new SqlParameter("@ID", txtID.Text));

                    // Delete from Catagory table  
                    dbHelper.ExecuteNonQuery(deleteQuery, new SqlParameter("@ID", txtID.Text));
                }
            }
            // Reload form  
            loadForm();
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
