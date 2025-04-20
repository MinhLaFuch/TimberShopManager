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
        private Account acc;
        private Product selectedProduct = null;
        private DynamicSearch dynamicSearch = null;
        private int selectedRowIndex = -1;

        private string
            name = "Bui Ngoc Quy",
            id = "E001";

        public frmSale()
        {
            InitializeComponent();
        }

        public frmSale(Account acc) : this()
        {
            this.acc = acc;
        }

        private void FormLoad()
        {
            txtPhoneNumber.AutoCompleteCustomSource = LoadAutoCompleteDataForCustomer();
            txtPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;

            dgvProduct.DataSource = LoadProduct();

            txtProductName.AutoCompleteCustomSource = LoadAutoCompleteDataForProduct();
            txtProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            if (dgvSale.Columns.Count == 0)
            {
                dgvSale.Columns.Add("ProductId", "Mã Sản Phẩm");
                dgvSale.Columns.Add("ProductName", "Tên Sản Phẩm");
                dgvSale.Columns.Add("Quantity", "Số Lượng");
                dgvSale.Columns.Add("PriceQuotation", "Giá Niêm Yết");
                dgvSale.Columns.Add("Tax", "Thuế");
                dgvSale.Columns.Add("Total", "Tổng Tiền");
                dgvSale.Columns.Add("WarrantyEnd", "Thời Gian Bảo Hành");
            }
        }

        private AutoCompleteStringCollection LoadAutoCompleteDataForProduct()
        {
            var autoCompleteCollection = new AutoCompleteStringCollection();

            string query = "SELECT Name FROM Product";
            List<string> items = dbHelper.GetDataForComboBox(query, "Name");

            foreach (var item in items)
            {
                autoCompleteCollection.Add(item);
            }
            return autoCompleteCollection;
        }

        public DataTable LoadProduct()
        {
            string query = @"SELECT 
                        Id AS 'Mã Sản Phẩm',
                        Name AS 'Tên Sản Phẩm',
                        CalculationUnit AS 'Đơn Vị Tính',
                        PriceQuotation AS 'Giá Niêm Yết',
                        Quantity AS 'Số Lượng',
                        CustomerWarranty AS 'Bảo Hành Khách Hàng',
                        Description AS 'Mô Tả'
                     FROM Product";
            return dbHelper.ExecuteQuery(query);
        }

        private AutoCompleteStringCollection LoadAutoCompleteDataForCustomer()
        {
            var autoCompleteCollection = new AutoCompleteStringCollection();

            string query = "SELECT PhoneNumber FROM Customer";
            List<string> items = dbHelper.GetDataForComboBox(query, "PhoneNumber");

            foreach (var item in items)
            {
                autoCompleteCollection.Add(item);
            }
            return autoCompleteCollection;
        }

        private void ClearGroupBoxCustomer()
        {
            txtPhoneNumber.Clear();
            txtCustomerName.Clear();
            txtAddress.Clear();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            txtEmployeeName.Text = name;
            FormLoad();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormLoad();

            gbCustomer.Enabled = true;
            pnlSearch.Enabled = true;

            string query = "SELECT TOP 1 SaleInvoiceId FROM SaleInvoice ORDER BY SaleInvoiceId DESC";

            string currentInvoiceId = Convert.ToString(dbHelper.ExecuteScalar(query));
            string invoiceId = Program.GenerateNextCode(currentInvoiceId, Product.PREFIX, Product.CODE_LENGTH);
            txtId.Text = invoiceId;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormLoad();
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
            // Kiểm tra xem sản phẩm đã được chọn chưa và số lượng có hợp lệ không
            if (selectedProduct == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }

            if (nudQuantity.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ!");
                return;
            }

            // Lấy giá trị từ các ô
            string productId = selectedProduct.Id;
            string productName = selectedProduct.Name;
            string unit = selectedProduct.CalculationUnit;
            decimal priceQuotation = Convert.ToDecimal(selectedProduct.PriceQuotation);
            decimal quantity = nudQuantity.Value;
            decimal tax = 0.1m; // Ví dụ: thuế 10%
            decimal total = priceQuotation * quantity * (1 + tax); // Tính tổng tiền (bao gồm thuế)
            DateTime warrantyEnd = DateTime.Now.AddMonths((int)selectedProduct.CustomerWarranty); // Thời gian bảo hành

            // Thêm vào dgvSale
            dgvSale.Rows.Add(productId, productName, quantity, priceQuotation, tax, total, warrantyEnd.ToString("dd/MM/yyyy"));

            // Cập nhật tổng tiền trong hóa đơn
            UpdateTotalAmount();
        }

        private void UpdateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvSale.Rows)
            {
                totalAmount += Convert.ToDecimal(row.Cells["Total"].Value); // Cộng tổng tiền từ tất cả các dòng
            }

            txtTotal.Text = totalAmount.ToString("N0"); // Hiển thị tổng tiền vào TextBox
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            Customer cus = null;
            if ((cus = Customer.GetCustomer(txtPhoneNumber.Text)) != null)
            {
                txtCustomerName.Text = cus.Name;
                txtAddress.Text = cus.Address;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            bool isValid = InputValidator.ValidateNotEmpty(new Dictionary<Control, Label>
            {
                {txtPhoneNumber, lbPhoneNumber },
                {txtCustomerName, lbCustomerName },
                {txtAddress, lbAddress }
            });

            if (isValid)
            {
                Customer newCustomer = new Customer("0987654321", "Nguyen Thi B", "456 Another St");
                Customer.add(newCustomer);
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e) => InputValidator.CheckInputIsDigit(e);
        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e) => InputValidator.CheckInputIsLetter(e);

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamicSearch?.Disable();
            if (e.RowIndex >= 0) // e.RowIndex sẽ là -1 nếu nhấp vào tiêu đề cột
            {
                DataGridViewRow selectedRow = dgvProduct.Rows[e.RowIndex];

                string id = selectedRow.Cells["Mã Sản Phẩm"].Value.ToString();
                string name = txtProductName.Text = selectedRow.Cells["Tên Sản Phẩm"].Value.ToString();
                string calculationUnit = lbUnit.Text = selectedRow.Cells["Đơn Vị Tính"].Value.ToString();
                string priceQuotation = selectedRow.Cells["Giá Niêm Yết"].Value.ToString();
                string quantity = selectedRow.Cells["Số Lượng"].Value.ToString();
                string customerWarranty = selectedRow.Cells["Bảo Hành Khách Hàng"].Value.ToString();
                string description = selectedRow.Cells["Mô Tả"].Value.ToString();

                selectedProduct = new Product(id, "", name, calculationUnit, priceQuotation, quantity, customerWarranty, description);
                nudQuantity.Maximum = Convert.ToDecimal(quantity);
                nudQuantity.Value = (nudQuantity.Maximum > 0) ? 1 : 0;
            }
        }

        private void txtProductName_Click(object sender, EventArgs e)
        {
            if (dynamicSearch == null)
            {
                dynamicSearch = new DynamicSearch(
                    new List<Control> { txtProductName },  // Các điều khiển tìm kiếm, ở đây chỉ có ComboBox
                    new Dictionary<string, string>
                    {
                        { "txtProductName", "Tên Sản Phẩm" }  // Ánh xạ tên điều khiển với tên cột trong DataTable
                    },
                    LoadProduct,
                    dgvProduct
                );
            }
            dynamicSearch?.Enable();
        }

        private void dgvSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                dgvSale.Rows.RemoveAt(selectedRowIndex);

                selectedRowIndex = -1;

                UpdateTotalAmount();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
            }
        }
    }
}
