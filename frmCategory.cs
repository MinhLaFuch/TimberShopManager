using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmCategory : Form
    {
        #region Properties
        private Category selectedCategory = null;
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private Account account;
        public frmCategory()
        {
            InitializeComponent();
        }
        public frmCategory(Account acc) : this()
        {
            this.account = acc;
        }
        #endregion
        #region Support Methods
        private void loadForm()
        {
            loadFormBasedOnRole();
            pnInfo.Enabled = false;
            txtId.ReadOnly = true;
            clearTextBox();
            dgv.DataSource = loadData();
            pnButtonEnabler(true);
            btnEnabler(false, true);
            searchEventEnabler(false);
            btnSave.Visible = true;
        }
        private void loadFormBasedOnRole()
        {
            bool authority = account.verifyPermission() == Employee.Role.ADMINISTRATOR || account.verifyPermission() == Employee.Role.MANAGER;
            btnAdd.Visible = btnMod.Visible = btnDel.Visible = authority;
        }
        private void clearTextBox()
        {
            txtId.Clear();
            txtName.Clear();
            txtDescription.Clear();
        }
        private DataTable loadData()
        {
            string query = "SELECT * FROM Category";
            DataTable dt = dbHelper.ExecuteQuery(query);
            return dt;
        }
        private void btnEnabler(bool featBtn, bool initBtn)
        {
            btnMod.Visible = btnDel.Visible = btnViewProduct.Visible = featBtn;
            btnAdd.Visible = btnSearch.Visible = initBtn;
        }
        private void pnButtonEnabler(bool b)
        {
            pnFeatureButton.Visible = b;
            pnInfoButton.Visible = !b;
        }
        private string idGenerator()
        {
            string query = "SELECT CategoryID FROM Category ORDER BY CategoryId DESC";
            DataTable dt = dbHelper.ExecuteQuery(query);
            string newId = "001";
            if (dt.Rows.Count > 0)
            {
                // Extracting maxID
                string maxId = dt.Rows[0]["EmployeeId"].ToString();
                int id = int.Parse(maxId.Substring(1, maxId.Length - 1)) + 1;
                newId = "000" + id.ToString();
                newId = newId.Substring(newId.Length - 3, 3);
            }
            return "CAT" + newId;
        }
        private void searchEventEnabler(bool b)
        {
            if (b)
            {
                txtId.TextChanged += txtID_TextChanged;
                txtName.TextChanged += txtName_TextChanged;
            }
            else
            {
                txtId.TextChanged -= txtID_TextChanged;
                txtName.TextChanged -= txtName_TextChanged;
            }
        }
        // Incomplete
        private void suggest()
        {

        }
        #endregion
        #region Events
        #region Load
        private void frmCategory_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        #endregion
        #region Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnInfo.Enabled = true;
            clearTextBox();
            txtName.Focus();
            pnButtonEnabler(false);
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            pnInfo.Enabled = true;
            txtName.Focus();
            pnButtonEnabler(false);
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            string insertDeletedQuery = "INSERT INTO DeletedCategory (categoryID, categoryName, Description) SELECT categoryID, categoryName, Description FROM category WHERE categoryID = @ID;";
            string deleteQuery = "DELETE FROM category WHERE categoryID = @ID;";

            // Get a confirmation from the user  
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn xóa danh mục này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                DataTable dt = dbHelper.ExecuteQuery("SELECT * FROM Product WHERE categoryID = @ID", new SqlParameter("@ID", txtId.Text));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Không thể xóa danh mục này vì nó đang được sử dụng trong sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Insert into Deletedcategory table  
                    dbHelper.ExecuteNonQuery(insertDeletedQuery, new SqlParameter("@ID", txtId.Text));

                    // Delete from category table  
                    dbHelper.ExecuteNonQuery(deleteQuery, new SqlParameter("@ID", txtId.Text));
                }
            }
            // Reload form  
            loadForm();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnInfo.Enabled = true;
            txtId.ReadOnly = false;
            txtId.Focus();
            pnButtonEnabler(false);
            btnSave.Visible = false;
            searchEventEnabler(true);
        }
        // Incomplete
        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct(account, selectedCategory);
            frmProduct.ShowDialog();
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve the selected row
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                // Populate the text boxes with the selected row's data
                txtId.Text = row.Cells["CategoryID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();

                // Enable/disable buttons as needed
                btnEnabler(true, true);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isAdding = string.IsNullOrEmpty(txtId.Text);
            if (isAdding)
            {
                string query = "INSERT INTO Category (CategoryID, categoryName, Description) VALUES (@ID, @Name, @Description)";
                dbHelper.ExecuteNonQuery(query,
                    new SqlParameter("@ID", idGenerator()),
                    new SqlParameter("@Name", txtName.Text),
                    new SqlParameter("@Description", txtDescription.Text));
            }
            else
            {
                string query = "UPDATE Category SET CategoryName = @Name, Description = @Description WHERE categoryID = @ID";
                dbHelper.ExecuteNonQuery(query,
                    new SqlParameter("@ID", txtId.Text),
                    new SqlParameter("@Name", txtName.Text),
                    new SqlParameter("@Description", txtDescription.Text));
            }
            loadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadForm();
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
        #endregion
        #endregion
    }
}
