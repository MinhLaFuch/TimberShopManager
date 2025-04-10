using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static timber_shop_manager.objects.Employee;

namespace timber_shop_manager
{
    public partial class frmSupplier : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public frmSupplier()
        {
            InitializeComponent();
        }
        #endregion
        #region Support Methods
        private void loadForm()
        {
            txtID.ReadOnly = true;
            clearTextBox();
            dgvSupplier.DataSource = loadData();
            gbInfo.Enabled = false;
            searchEventEnabler(false);
            btnEnabler(false, true);
        }
        private DataTable loadData()
        {
            string sql = "SELECT * FROM Supplier";
            DataTable dt = dbHelper.ExecuteQuery(sql);
            return dt;
        }
        private void btnEnabler(bool featBtn, bool initBtn)
        {
            btnDel.Enabled = btnMod.Enabled = featBtn;
            btnAdd.Enabled = btnSearch.Enabled = initBtn;
        }
        private void clearTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtWebsite.Clear();
        }
        private void searchEventEnabler(bool b)
        {
            if (b)
            {
                txtID.TextChanged += txtID_TextChanged;
                txtName.TextChanged += txtName_TextChanged;
                txtPhoneNumber.TextChanged += txtPhoneNumber_TextChanged;
                txtAddress.TextChanged += txtAddress_TextChanged;
                txtEmail.TextChanged += txtEmail_TextChanged;
                txtWebsite.TextChanged += txtWebsite_TextChanged;
            }
            else
            {
                txtID.TextChanged -= txtID_TextChanged;
                txtName.TextChanged -= txtName_TextChanged;
                txtPhoneNumber.TextChanged -= txtPhoneNumber_TextChanged;
                txtAddress.TextChanged -= txtAddress_TextChanged;
                txtEmail.TextChanged -= txtEmail_TextChanged;
                txtWebsite.TextChanged -= txtWebsite_TextChanged;
            }
        }
        //Not done
        private string idGenerator()
        {
            return "";
        }
        private void suggestSupplier()
        {

        }
        //---
        #endregion
        #region Events
        #region Load
        private void frmSupplier_Load(object sender, EventArgs e)
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
            string query = "DELETE FROM Supplier WHERE SupplierID = @id";
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                dbHelper.ExecuteNonQuery(query, new SqlParameter("@ID", txtID.Text));
            }

            // Reload form
            loadForm();
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            gbInfo.Enabled = true;
            txtName.Focus();
            btnEnabler(false, false);
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isAdding = string.IsNullOrEmpty(txtID.Text);
            string query = "";

            if (isAdding)
            {
                query = "INSERT INTO Suppliers (SupplierId, Name, PhoneNumber, Address, Email, Website) " +
                        "VALUES (@ID, @Name, @PhoneNumber, @Address, @Email, @Website)";
                dbHelper.ExecuteNonQuery(query,
                    new SqlParameter("@ID", idGenerator()),
                    new SqlParameter("@Name", txtName.Text),
                    new SqlParameter("@PhoneNumber", txtPhoneNumber.Text),
                    new SqlParameter("@Address", txtAddress.Text),
                    new SqlParameter("@Email", txtEmail.Text),
                    new SqlParameter("@Website", txtWebsite.Text));
            }
            else
            {
                query = "UPDATE Suppliers SET Name = @Name, PhoneNumber = @PhoneNumber, Address = @Address, " +
                        "Email = @Email, Website = @Website WHERE SupplierID = @ID";
                dbHelper.ExecuteNonQuery(query,
                    new SqlParameter("@ID", txtID.Text),
                    new SqlParameter("@Name", txtName.Text),
                    new SqlParameter("@PhoneNumber", txtPhoneNumber.Text),
                    new SqlParameter("@Address", txtAddress.Text),
                    new SqlParameter("@Email", txtEmail.Text),
                    new SqlParameter("@Website", txtWebsite.Text));
            }

            // Reload form
            loadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadForm();
        }
        private void dgvSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvSupplier.Rows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];

                // Fill all info to groupbox
                txtID.Text = row.Cells["SupplierID"].Value?.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtPhoneNumber.Text = row.Cells["ContactNumber"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtWebsite.Text = row.Cells["Website"].Value?.ToString();

                // Enable buttons
                btnEnabler(true, true);
            }
        }
        #endregion
        #region Key Press
        // Need to do input validation for email and website?
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CheckInputIsDigit(e);
        }
        #endregion
        #region Text Change
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            suggestSupplier();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            suggestSupplier();
        }
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            suggestSupplier();
        }
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            suggestSupplier();
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            suggestSupplier();
        }
        private void txtWebsite_TextChanged(object sender, EventArgs e)
        {
            suggestSupplier();
        }
        #endregion
        #endregion
    }
}
