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
    public partial class frmProduct : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private string catagoryID = "";
        private string catagoryName = "";
        public string CatagoryID
        {
            get { return catagoryID; }
            set { catagoryID = value; }
        }
        public string CatagoryName
        {
            get { return catagoryName; }
            set { catagoryName = value; }
        }
        public frmProduct()
        {
            InitializeComponent();
        }
        #endregion
        #region Support Methods
        private void loadForm()
        {
            txtID.ReadOnly = true;
            txtQuantity.ReadOnly = true;
            dgvProduct.DataSource = loadData();
            btnEnabler(false, true);
            searchEventEnabler(false);
            // Fill the cbCatagory with data
            if (!String.IsNullOrEmpty(catagoryID))
            {
                cbCatagory.Items.Insert(0,catagoryName);
                cbCatagory.SelectedIndex = 0;
            }
            else
            {
                List<string> catagoryName = new List<string>();
                foreach (DataRow row in dbHelper.ExecuteQuery("SELECT Name FROM Catagory").Rows)
                {
                    if (row["Name"] == DBNull.Value) continue;
                    else catagoryName.Add(row["Name"].ToString());
                }
                cbCatagory.DataSource = catagoryName;
            }
            // Fill the cbCalUnit with data
            List<string> calUnit = new List<string>();
            foreach (DataRow row in dbHelper.ExecuteQuery("SELECT distinct CalculationUnit FROM Product").Rows)
            {
                if (row["CalculationUnit"] == DBNull.Value) continue;
                else calUnit.Add(row["CalculationUnit"].ToString());
            }
            cbCalUnit.DataSource = calUnit;
            clearTextBox();
            gbEnabler(false);
        }
        private void gbEnabler(bool b)
        {
            gbInfo.Enabled = b;
            // Disable if this is from Catagory
            if (!String.IsNullOrEmpty(catagoryID))
            {
                cbCatagory.Enabled = false;
            }
            else
            {
                cbCatagory.Enabled = true;
            }
        }
        private void clearTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            txtPriceQuotation.Clear();
            txtQuantity.Clear();
            nudWarranty.Value = nudWarranty.Minimum;
            txtDescription.Clear();
            cbCalUnit.Text = String.Empty;
            // Only not clear if this is from Catagory
            if (String.IsNullOrEmpty(catagoryID)) cbCatagory.SelectedIndex = -1;
        }
        private DataTable loadData()
        {
            string query = "";
            DataTable dt = new DataTable();
            if (!String.IsNullOrEmpty(catagoryID))
            {
                query = "SELECT * FROM Product WHERE CatagoryID = @CatagoryID";
                dt = dbHelper.ExecuteQuery(query, new SqlParameter("@CatagoryID", this.catagoryID));
            }
            else
            {
                query = "SELECT * FROM Product";
                dt = dbHelper.ExecuteQuery(query);
            }
            return dt;
        }
        private void btnEnabler(bool featBtn, bool initBtn)
        {
            btnDel.Enabled = btnMod.Enabled = featBtn;
            btnAdd.Enabled = btnSearch.Enabled = initBtn;
        }
        private string getCatagoryID(string catagoryName)
        {
            string query = "SELECT CatagoryID FROM Catagory WHERE Name = @name";
            DataTable dt = dbHelper.ExecuteQuery(query, new SqlParameter("@name", catagoryName));
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["CatagoryID"].ToString();
            }
            else
            {
                return "";
            }
        }
        private string getCatagoryName(string catagoryID)
        {
            string query = "SELECT Name FROM Catagory WHERE CatagoryID = @ID";
            DataTable dt = dbHelper.ExecuteQuery(query, new SqlParameter("@ID", catagoryID));
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["Name"].ToString();
            }
            else
            {
                return "";
            }
        }
        private void searchEventEnabler(bool b)
        {
            if (b)
            {
                txtID.TextChanged += txtID_TextChanged;
                txtName.TextChanged += txtName_TextChanged;
                txtPriceQuotation.TextChanged += txtPriceQuotation_TextChanged;
                cbCatagory.SelectedValueChanged += cbCatagory_SelectedValueChanged;
            }
            else
            {
                txtID.TextChanged -= txtID_TextChanged;
                txtName.TextChanged -= txtName_TextChanged;
                txtPriceQuotation.TextChanged -= txtPriceQuotation_TextChanged;
                cbCatagory.SelectedValueChanged -= cbCatagory_SelectedValueChanged;
            }
        }
        // Not done---
        private void suggestProduct()
        {

        }
        //---
        private string idGenerator()
        {
            string query = "SELECT ProductID FROM Product ORDER BY ProductID DESC";
            DataTable dt = dbHelper.ExecuteQuery(query);
            string newId = "0001";
            if (dt.Rows.Count > 0)
            {
                // Extracting maxID
                string maxId = dt.Rows[0]["ProductID"].ToString();
                int id = int.Parse(maxId.Substring(1, maxId.Length - 1)) + 1;
                newId = "0000" + id.ToString();
                newId = newId.Substring(newId.Length - 4, 4);
            }
            return "P" + newId;
        }
        #endregion
        #region Events
        #region Load
        private void frmProduct_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        #endregion
        #region Click
        private void btnSearch_Click(object sender, EventArgs e)
        {
            gbEnabler(true);
            txtID.ReadOnly = false;
            btnSave.Enabled = false;
            txtID.Focus();
            btnEnabler(false, false);
            searchEventEnabler(true);
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Product WHERE ProductID = @ID";
            // Get a confirmation from the user
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn xóa sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                if (int.Parse(txtQuantity.Text) == 0)
                {
                    dbHelper.ExecuteNonQuery(query, new SqlParameter("@ID", txtID.Text));
                }
                else
                {
                    DialogResult decline = MessageBox.Show("Bạn không thể xóa sản phẩm vì còn hàng trong kho !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Reload form
            loadForm();
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            gbEnabler(true);
            txtName.Focus();
            btnEnabler(false, false);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            gbEnabler(true);
            clearTextBox();
            txtName.Focus();
            btnEnabler(false, false);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isAdding = string.IsNullOrEmpty(txtID.Text);
            string query = "";
            if (isAdding)
            {
                query = "INSERT INTO Product (ProductID, CatagoryID, Name, CalculationUnit, PriceQuotation, CustomerWarranty, Description, Quantity) " +
                        "VALUES (@ID, @CatagoryID, @Name, @CalUnit, @PriceQuo, @Warranty, @Description, @Quantity)";
                dbHelper.ExecuteNonQuery(query,
                    new SqlParameter("@ID", idGenerator()),
                    new SqlParameter("@CatagoryID", getCatagoryID(cbCatagory.Text)),
                    new SqlParameter("@Name", txtName.Text),
                    new SqlParameter("@CalUnit", cbCalUnit.Text),
                    new SqlParameter("@PriceQuo", txtPriceQuotation.Text),
                    new SqlParameter("@Warranty", nudWarranty.Value),
                    new SqlParameter("@Description", txtDescription.Text),
                    new SqlParameter("@Quantity", int.Parse(txtQuantity.Text)));
            }
            else
            {
                query = "UPDATE Product SET " +
                        "CatagoryID = @CatagoryID, " +
                        "Name = @Name, " +
                        "CalculationUnit = @CalUnit, " +
                        "PriceQuotation = @PriceQuo, " +
                        "CustomerWarranty = @Warranty, " +
                        "Description = @Description, " +
                        "Quantity = @Quantity " +
                        "WHERE ProductID = @ID";
                dbHelper.ExecuteNonQuery(query,
                    new SqlParameter("@ID", txtID.Text),
                    new SqlParameter("@CatagoryID", getCatagoryID(cbCatagory.Text)),
                    new SqlParameter("@Name", txtName.Text),
                    new SqlParameter("@CalUnit", cbCalUnit.Text),
                    new SqlParameter("@PriceQuo", txtPriceQuotation.Text),
                    new SqlParameter("@Warranty", nudWarranty.Value),
                    new SqlParameter("@Description", txtDescription.Text),
                    new SqlParameter("@Quantity", int.Parse(txtQuantity.Text)));
            }
            // Reload form
            loadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadForm();
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row or an invalid row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvProduct.Rows[e.RowIndex];

                // Populate the form fields with the selected row's data
                txtID.Text = selectedRow.Cells["ProductID"].Value?.ToString();
                txtName.Text = selectedRow.Cells["Name"].Value?.ToString();
                cbCalUnit.Text = selectedRow.Cells["CalculationUnit"].Value?.ToString();
                txtPriceQuotation.Text = selectedRow.Cells["PriceQuotation"].Value?.ToString();
                cbCatagory.Text = getCatagoryName(selectedRow.Cells["CatagoryID"].Value?.ToString());
                nudWarranty.Value = Convert.ToDecimal(selectedRow.Cells["CustomerWarranty"].Value ?? nudWarranty.Minimum);
                txtQuantity.Text = selectedRow.Cells["Quantity"].Value?.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value?.ToString();

                btnEnabler(true, true);
            }
        }
        #endregion
        #region Text Changed
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            suggestProduct();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            suggestProduct();
        }
        private void txtPriceQuotation_TextChanged(object sender, EventArgs e)
        {
            suggestProduct();
        }
        private void cbCatagory_SelectedValueChanged(object sender, EventArgs e)
        {
            suggestProduct();
        }
        #endregion
        #region Key Press
        private void txtPriceQuotation_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CheckInputIsDigit(e);
        }
        #endregion
        #endregion
    }
}
