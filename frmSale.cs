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
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public frmSale()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            grbCustomer.Enabled = true;
            pnlSearch.Enabled = true;

            string query = "SELECT TOP 1 SaleInvoiceId FROM SaleInvoice ORDER BY SaleInvoiceId DESC";

            string currentInvoiceId = Convert.ToString(dbHelper.ExecuteScalar(query));
            string invoiceId = Program.GenerateNextCode(currentInvoiceId, Product.PREFIX, Product.CODE_LENGTH);
            txtInvoiceId.Text = invoiceId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }

        private void cbbSearch_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbSearch.SelectedIndex != -1)
            {
                btnAdd.Enabled = true;
                string id = GetIdFromString(cbbSearch.Text);

                string queryQuantity = "SELECT Quantity FROM Product WHERE ProductId = @id";
                string queryUnit = "SELECT CalculationUnit FROM Product WHERE ProductId = @id";

                int quantity = Convert.ToInt32(dbHelper.ExecuteScalar(queryQuantity, new SqlParameter("@id", id)));
                string unit = Convert.ToString(dbHelper.ExecuteScalar(queryUnit, new SqlParameter("@id", id)));
                lblUnit.Text = unit;


                nudQuantity.Maximum = quantity;

                if (nudQuantity.Maximum == Product.SOLD_OUT)
                {
                    btnAdd.Enabled = false;

                    MessageBox.Show("Mặt hàng này đã hết!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public string GetIdFromString(string input)
        {
            string[] parts = input.Split(" - ");

            if (parts.Length < 3)
            {
                return null;
            }

            return parts[0].Trim();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void FormLoad()
        {
            LoadComboboxSearch();

            pnlSearch.Enabled = false;
            grbCustomer.Enabled = false;
            txtCustomer.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();

            txtInvoiceId.Clear();
        }

        private void LoadComboboxSearch()
        {
            string query = "SELECT ProductId, Name, CalculationUnit, PriceQuotation, CustomerWarranty, Description, Quantity FROM Product";

            List<string> data = dbHelper.GetDataForList(query, reader => new Product(
                reader.GetString(reader.GetOrdinal("ProductId")),
                reader.GetString(reader.GetOrdinal("Name")),
                reader.GetString(reader.GetOrdinal("CalculationUnit")),
                reader.GetDouble(reader.GetOrdinal("PriceQuotation")),
                reader.GetInt32(reader.GetOrdinal("CustomerWarranty")),
                reader.GetString(reader.GetOrdinal("Description")),
                reader.GetInt32(reader.GetOrdinal("Quantity"))
                ).ToString());

            cbbSearch.DataSource = data;
            cbbSearch.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormLoad();
        }
    }
}
