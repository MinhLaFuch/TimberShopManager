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

namespace timber_shop_manager
{
    public partial class frmSale : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private Account account;
        public frmSale(Account account)
        {
            InitializeComponent();
            this.account = account;
        }
        #endregion
        #region Support methods
        public string GetIdFromString(string input)
        {
            string[] parts = input.Split(" - ");

            if (parts.Length < 3)
            {
                return null;
            }

            return parts[0].Trim();
        }
        private void FormLoad()
        {
            LoadComboboxSearch();
            ClearGroupBoxCustomer();

            pnlSearch.Enabled = false;
            gbCustomer.Enabled = false;


            txtID.Clear();
        }

        private void LoadComboboxSearch()
        {
            string query = "SELECT ProductId, CatagoryId, Name, CalculationUnit, PriceQuotation, CustomerWarranty, Description, Quantity FROM Product";

            List<string> data = dbHelper.GetDataForList(query, reader => new Product(
                reader.GetString(reader.GetOrdinal("ProductId")),
                reader.GetString(reader.GetOrdinal("CatagoryId")),
                reader.GetString(reader.GetOrdinal("Name")),
                reader.GetString(reader.GetOrdinal("CalculationUnit")),
                reader.GetDouble(reader.GetOrdinal("PriceQuotation")),
                reader.GetInt32(reader.GetOrdinal("CustomerWarranty")),
                reader.GetString(reader.GetOrdinal("Description")),
                reader.GetInt32(reader.GetOrdinal("Quantity"))
                ).ToString());

            cbSearchProduct.DataSource = data;
            cbSearchProduct.SelectedIndex = -1;
        }
        private void ClearGroupBoxCustomer()
        {
            txtPhoneNumber.Clear();
            txtCustomerName.Clear();
            txtAddress.Clear();
        }
        #endregion
        #region Events
        #region Load
        private void frmSale_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        #endregion
        #region Click
        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormLoad();

            gbCustomer.Enabled = true;
            pnlSearch.Enabled = true;

            string query = "SELECT TOP 1 SaleInvoiceId FROM SaleInvoice ORDER BY SaleInvoiceId DESC";

            string currentInvoiceId = Convert.ToString(dbHelper.ExecuteScalar(query));
            string invoiceId = Program.GenerateNextCode(currentInvoiceId, Product.PREFIX, Product.CODE_LENGTH);
            txtID.Text = invoiceId;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer(Employee.Role.SALE_AGENT);
            frmCustomer.ShowDialog();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmCustomer.CheckInputIsDigit(e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGroupBoxCustomer();
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region TextChanged
        private void cbbSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSearchProduct.SelectedIndex != -1)
            {
                btnAddProduct.Enabled = true;
                string id = GetIdFromString(cbSearchProduct.Text);

                string queryQuantity = "SELECT Quantity FROM Product WHERE ProductId = @id";
                string queryUnit = "SELECT CalculationUnit FROM Product WHERE ProductId = @id";

                int quantity = Convert.ToInt32(dbHelper.ExecuteScalar(queryQuantity, new SqlParameter("@id", id)));
                string unit = Convert.ToString(dbHelper.ExecuteScalar(queryUnit, new SqlParameter("@id", id)));
                lblUnit.Text = unit;


                nudQuantity.Maximum = quantity;

                if (nudQuantity.Maximum == Product.SOLD_OUT)
                {
                    btnAddProduct.Enabled = false;

                    MessageBox.Show("Mặt hàng này đã hết!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion
        #endregion
    }
}
