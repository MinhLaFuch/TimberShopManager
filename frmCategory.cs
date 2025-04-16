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

namespace timber_shop_manager
{
    public partial class frmCategory : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public frmCategory()
        {
            InitializeComponent();
        }
        #endregion
        #region Support Methods
        private void loadForm()
        {
            txtID.ReadOnly = true;
            clearTextBox();
            dgv.DataSource = loadData();
            btnEnabler(false, true);
            gbInfo.Enabled = false;
            searchEventEnabler(false);
        }
        private void clearTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            txtDescription.Clear();
        }
        private DataTable loadData()
        {
            string query = "SELECT * FROM Catagory";
            DataTable dt = dbHelper.ExecuteQuery(query);
            return dt;
        }
        private void btnEnabler(bool featBtn, bool initBtn)
        {
            btnMod.Enabled = btnDel.Enabled = btnViewProduct.Enabled = featBtn;
            btnAdd.Enabled = btnSearch.Enabled = initBtn;
        }
        private string idGenerator()
        {
            string query = "SELECT CatagoryID FROM Catagory ORDER BY CatagoryId DESC";
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
                txtID.TextChanged += txtID_TextChanged;
                txtName.TextChanged += txtName_TextChanged;
            }
            else
            {
                txtID.TextChanged -= txtID_TextChanged;
                txtName.TextChanged -= txtName_TextChanged;
            }
        }
        // Incomplete
        private void suggestCatagory()
        {

        }
        #endregion
        #region Events
        #region Load
        private void frmCatagory_Load(object sender, EventArgs e)
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
        private void btnMod_Click(object sender, EventArgs e)
        {
            gbInfo.Enabled = true;
            txtName.Focus();
            btnEnabler(false, false);
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Catagory WHERE Catagory = @ID";
            // Get a confirmation from the user
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn xóa danh mục này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                DataTable dt = dbHelper.ExecuteQuery("SELECT * FROM Product WHERE CatagoryID = @ID", new SqlParameter("@ID", txtID.Text));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Không thể xóa danh mục này vì nó đang được sử dụng trong sản phẩm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dbHelper.ExecuteNonQuery(query, new SqlParameter("@ID", txtID.Text));

                }
            }
            // Reload form
            loadForm();
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
        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct();
            //frmProduct.CatagoryID = txtID.Text;
            //frmProduct.CatagoryName = txtName.Text;
            frmProduct.ShowDialog();
        }
        private void dgvCatagory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Retrieve the selected row
                DataGridViewRow row = dgv.Rows[e.RowIndex];

                // Populate the text boxes with the selected row's data
                txtID.Text = row.Cells["CatagoryID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();

                // Enable/disable buttons as needed
                btnEnabler(true, true);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isAdding = string.IsNullOrEmpty(txtID.Text);
            if (isAdding)
            {
                string query = "INSERT INTO Catagory (CatagoryID, CatagoryName, Description) VALUES (@ID, @Name, @Description)";
                dbHelper.ExecuteNonQuery(query,
                    new SqlParameter("@ID", idGenerator()),
                    new SqlParameter("@Name", txtName.Text),
                    new SqlParameter("@Description", txtDescription.Text));
            }
            else
            {
                string query = "UPDATE Catagory SET CatagoryName = @Name, Description = @Description WHERE CatagoryID = @ID";
                dbHelper.ExecuteNonQuery(query,
                    new SqlParameter("@ID", txtID.Text),
                    new SqlParameter("@Name", txtName.Text),
                    new SqlParameter("@Description", txtDescription.Text));
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadForm();
        }
        #endregion
        #region Text Changed
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            suggestCatagory();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            suggestCatagory();

        }
        #endregion
        #endregion


        private void lbName_Click(object sender, EventArgs e)
        {

        }
    }
}
