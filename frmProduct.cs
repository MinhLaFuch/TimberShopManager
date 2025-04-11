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
using timber_shop_manager.objects;
using static timber_shop_manager.objects.Employee;
namespace timber_shop_manager
{
    public partial class frmProduct : Form
    {
        private Product selectedProduct = null;
        private static DynamicSearch dynamicSearch = null;

        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public frmProduct()
        {
            InitializeComponent();
        }

        #endregion
        #region Support Methods
        private void LoadComboBoxCatagory()
        {
            string query = "SELECT DISTINCT Name FROM Catagory";
            List<string> ls = dbHelper.GetDataForComboBox(query, "Name");
            cbCatagory.DataSource = ls;
            cbCatagory.SelectedIndex = -1;
        }
        private void LoadComboBoxUnit()
        {
            string query = "SELECT DISTINCT CalculationUnit FROM Product";
            List<string> ls = dbHelper.GetDataForComboBox(query, "CalculationUnit");
            cbCalUnit.DataSource = ls;
            cbCalUnit.SelectedIndex = -1;
        }
        private void loadForm()
        {
            txtID.Enabled = false;
            nudQuantity.Enabled = false;
            dgvProduct.DataSource = loadData();

            btnEnabler(false, true);

            LoadComboBoxCatagory();
            LoadComboBoxUnit();

            clearTextBox();
            gbEnabler(false);
        }
        private void gbEnabler(bool b)
        {
            gbInfo.Enabled = b;
        }
        private void clearTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            nudPrice.Value = 0;
            nudQuantity.Value = 0;
            nudWarranty.Value = nudWarranty.Minimum;
            txtDescription.Clear();
            cbCalUnit.SelectedIndex = -1;
            cbCatagory.SelectedIndex = -1;
        }
        private DataTable loadData()
        {
            string query = "SELECT * FROM Product";
            DataTable dt = dbHelper.ExecuteQuery(query);
            return dt;
        }
        private void btnEnabler(bool featBtn, bool initBtn)
        {
            btnDel.Enabled = btnMod.Enabled = featBtn;
            btnAdd.Enabled = btnSearch.Enabled = initBtn;
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
            txtID.Enabled = true;
            gbEnabler(true);
            btnSave.Enabled = false;
            txtID.Focus();
            btnEnabler(false, false);

            if (dynamicSearch == null)
            {
                List<Control> searchControls = new List<Control>() {txtID, txtName, cbCalUnit, txtDescription};
                Dictionary<string, string> columnMappings = new Dictionary<string, string>()
                {
                    {"txtID", "ProductId" },
                    {"txtName", "Name" },
                    {"cbCalUnit", "CalculationUnit" },
                    {"txtDescription", "Description" }
                };
                dynamicSearch = new DynamicSearch(searchControls, columnMappings, loadData, dgvProduct);
            }
            dynamicSearch?.Enable();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            Product.delete(selectedProduct);

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

            string lastCode = Convert.ToString(dbHelper.ExecuteScalar("SELECT TOP 1 ProductId FROM Product ORDER BY ProductId DESC"));
            txtID.Text = Program.GenerateNextCode(lastCode, Product.PREFIX, Product.CODE_LENGTH);
            txtName.Focus();
            nudQuantity.Enabled = true;
            btnEnabler(false, false);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product(txtID.Text, Catagory.getId(cbCatagory.Text), txtName.Text, cbCalUnit.Text, Convert.ToDouble(nudPrice.Value), Convert.ToInt32(nudWarranty.Value), txtDescription.Text, Convert.ToInt32(nudWarranty.Value));
            Product.add(product);
            // Reload form
            loadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dynamicSearch?.Disable();
            loadForm();
        }
        
        #endregion
        

        #region Key Press
        private void txtPriceQuotation_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CheckInputIsDigit(e);
        }
        #endregion
        #endregion

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamicSearch?.Disable();
            // Ensure the click is not on the header row or an invalid row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvProduct.Rows[e.RowIndex];

                // Populate the form fields with the selected row's data
                txtID.Text = selectedRow.Cells["ProductId"].Value?.ToString().Trim();
                txtName.Text = selectedRow.Cells["Name"].Value?.ToString();
                cbCalUnit.Text = selectedRow.Cells["CalculationUnit"].Value?.ToString();
                nudPrice.Value = Convert.ToInt32(selectedRow.Cells["PriceQuotation"].Value);
                cbCatagory.Text = Catagory.getName(selectedRow.Cells["CatagoryId"].Value?.ToString());
                nudWarranty.Value = Convert.ToDecimal(selectedRow.Cells["CustomerWarranty"].Value);
                nudQuantity.Text = selectedRow.Cells["Quantity"].Value?.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value?.ToString();

                selectedProduct = new Product(txtID.Text, cbCatagory.Text, txtName.Text, cbCalUnit.Text, Convert.ToDouble(nudPrice.Value), Convert.ToInt32(nudWarranty.Value), txtDescription.Text, Convert.ToInt32(nudQuantity.Value));

                btnEnabler(true, true);
            }
        }
    }
}
