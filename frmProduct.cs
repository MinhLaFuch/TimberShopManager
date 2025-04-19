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
        private Category category = null;
        private static DynamicSearch dynamicSearch = null;
        private Account account;
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public frmProduct()
        {
            InitializeComponent();
        }
        public frmProduct(Account acc): this()
        {
            this.account = acc;
        }
        public frmProduct(Account acc, Category cat) : this()
        {
            this.account = acc;
            this.category = cat;
        }
        #endregion
        #region Support Methods
        private void LoadComboBoxCatagory()
        {
            string query = "SELECT DISTINCT Name FROM Catagory";
            List<string> ls = dbHelper.GetDataForComboBox(query, "Name");
            cbCategory.DataSource = ls;
            cbCategory.SelectedIndex = -1;
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
            txtID.ReadOnly = true;
            pnInfo.Enabled = false;
            dgv.DataSource = loadData();

            btnEnabler(false, true);
            pnButtonEnabler(true);

            LoadComboBoxCatagory();
            LoadComboBoxUnit();

            clearTextBox();

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
            cbCategory.SelectedIndex = -1;
        }
        private DataTable loadData()
        {
            string query = "SELECT * FROM Product";
            DataTable dt = dbHelper.ExecuteQuery(query);
            return dt;
        }
        private void btnEnabler(bool cellBtn, bool initBtn)
        {
            btnDel.Visible = btnMod.Visible = cellBtn;
            btnAdd.Visible = btnSearch.Visible = initBtn;
        }
        private void pnButtonEnabler(bool b)
        {
            pnFeatureButton.Visible = b;
            pnInfoButton.Visible = !b;
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
            pnInfo.Enabled = true;
            txtID.ReadOnly = false;
            nudQuantity.Enabled = false;
            btnSave.Visible = false;
            txtID.Focus();
            pnButtonEnabler(false);
            clearTextBox();

            if (dynamicSearch == null)
            {
                List<Control> searchControls = new List<Control>() { txtID, txtName, cbCalUnit, txtDescription };
                Dictionary<string, string> columnMappings = new Dictionary<string, string>()
                {
                    {"txtID", "ProductId" },
                    {"txtName", "Name" },
                    {"cbCalUnit", "CalculationUnit" },
                    {"txtDescription", "Description" }
                };
                dynamicSearch = new DynamicSearch(searchControls, columnMappings, loadData, dgv);
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
            pnInfo.Enabled = true;
            txtName.Focus();
            pnButtonEnabler(false);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnInfo.Enabled = true;
            txtName.Focus();
            clearTextBox();
            pnButtonEnabler(false);

            string lastCode = Convert.ToString(dbHelper.ExecuteScalar("SELECT TOP 1 ProductId FROM Product ORDER BY ProductId DESC"));
            txtID.Text = Program.GenerateNextCode(lastCode, Product.PREFIX, Product.CODE_LENGTH);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product(txtID.Text, Category.getId(cbCategory.Text), txtName.Text, cbCalUnit.Text, Convert.ToDouble(nudPrice.Value), Convert.ToInt32(nudWarranty.Value), txtDescription.Text, Convert.ToInt32(nudWarranty.Value));
            Product.add(product);
            // Reload form
            loadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            dynamicSearch?.Disable();
            loadForm();
            nudQuantity.Enabled = true;
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamicSearch?.Disable();
            // Ensure the click is not on the header row or an invalid row
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];

                // Populate the form fields with the selected row's data
                txtID.Text = selectedRow.Cells["ProductId"].Value?.ToString().Trim();
                txtName.Text = selectedRow.Cells["Name"].Value?.ToString();
                cbCalUnit.Text = selectedRow.Cells["CalculationUnit"].Value?.ToString();
                nudPrice.Value = Convert.ToInt32(selectedRow.Cells["PriceQuotation"].Value);
                cbCategory.Text = Category.getName(selectedRow.Cells["CatagoryId"].Value?.ToString());
                nudWarranty.Value = Convert.ToDecimal(selectedRow.Cells["CustomerWarranty"].Value);
                nudQuantity.Text = selectedRow.Cells["Quantity"].Value?.ToString();
                txtDescription.Text = selectedRow.Cells["Description"].Value?.ToString();

                selectedProduct = new Product(txtID.Text, cbCategory.Text, txtName.Text, cbCalUnit.Text, Convert.ToDouble(nudPrice.Value), Convert.ToInt32(nudWarranty.Value), txtDescription.Text, Convert.ToInt32(nudQuantity.Value));

                btnEnabler(true, true);
            }
        }
        #endregion


        #region Key Press
        private void txtPriceQuotation_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Program.CheckInputIsDigit(e);
        }
        #endregion
        #endregion

    }
}
