using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Guna.UI2.WinForms;
using timber_shop_manager.BUS;
using timber_shop_manager.DTO;

namespace timber_shop_manager.GUI
{
    public partial class frmImport : Form
    {
        private EmployeeDTO emp;
        private SupplierBUS supplierBUS = new SupplierBUS();
        private CategoryBUS categoryBUS = new();
        private ImportInvoiceBUS importInvoiceBUS = new();
        private bool _isAutoFilling = false;

        private string employeeId = "E001";

        public frmImport()
        {
            InitializeComponent();
            dtpImportTime.Value = DateTime.Now;
        }

        public frmImport(EmployeeDTO emp) : this()
        {
            this.emp = emp;
            employeeId = emp.Id;
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            txtEmployeeId.Text = employeeId;

            txtProductId.Enabled = false;
            SupplierBUS supplierBUS = new SupplierBUS();
            List<string> phoneNumbers = supplierBUS.GetSupplierPhoneNumbers();

            AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();
            autoSource.AddRange(phoneNumbers.ToArray());

            txtSupplierPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSupplierPhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSupplierPhoneNumber.AutoCompleteCustomSource = autoSource;

            ProductBUS productBUS = new ProductBUS();
            List<string> productNames = productBUS.GetAllProducts()
                                                  .AsEnumerable()
                                                  .Select(r => r.Field<string>("Tên sản phẩm"))
                                                  .Distinct()
            .ToList();

            SetAutoComplete(txtProductName, productNames);
            LoadCategories();

            InitializeProductGridViewColumns();
            LoadCalculationUnits();

            nudPriceQuotation.Maximum = nudQuantity.Maximum = nudWarranty.Maximum = int.MaxValue;
            txtInvoiceId.Text = importInvoiceBUS.GenerateNewInvoiceId();
        }

        private void LoadCalculationUnits()
        {
            ProductBUS bus = new ProductBUS();
            var units = bus.GetUnits();

            cbCalUnit.Items.Clear();
            cbCalUnit.Items.AddRange(units.ToArray());

            if (cbCalUnit.Items.Count > 0)
                cbCalUnit.SelectedIndex = -1; // Chọn mặc định
        }


        private void InitializeProductGridViewColumns()
        {
            if (dgv.Columns.Count > 0) return; // Tránh thêm lặp lại

            dgv.Columns.Clear();

            dgv.Columns.Add("Id", "Mã sản phẩm");
            dgv.Columns.Add("Name", "Tên sản phẩm");
            dgv.Columns.Add("Category", "Loại");
            dgv.Columns.Add("Unit", "ĐVT");
            dgv.Columns.Add("Price", "Đơn giá");
            dgv.Columns.Add("Quantity", "Số lượng");
            dgv.Columns.Add("Warranty", "Bảo hành");
            dgv.Columns.Add("Tax (%)", "Thuế (%)");
            dgv.Columns.Add("Description", "Mô tả");

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void LoadCategories()
        {
            var categoryTable = categoryBUS.GetAllCategories();
            cbCategory.Items.Clear();
            foreach (DataRow row in categoryTable.Rows)
            {
                cbCategory.Items.Add(row["Tên"].ToString());
            }

            cbCategory.SelectedIndex = -1;
        }

        private bool ValidateBeforeSave()
        {
            // Kiểm tra thông tin nhà cung cấp
            if (string.IsNullOrWhiteSpace(txtSupplierid.Text) ||
                string.IsNullOrWhiteSpace(txtSupplierName.Text) ||
                string.IsNullOrWhiteSpace(txtSupplierPhoneNumber.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin nhà cung cấp.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Kiểm tra có sản phẩm nào trong danh sách không
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm trước khi lưu.", "Thiếu sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }



        private void SetAutoComplete(TextBox textBox, IEnumerable<string> data)
        {
            var autoSource = new AutoCompleteStringCollection();
            autoSource.AddRange(data.ToArray());

            textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.AutoCompleteCustomSource = autoSource;
        }

        private void txtSupplierPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            string phone = txtSupplierPhoneNumber.Text.Trim();
            if (string.IsNullOrEmpty(phone)) return;

            SupplierBUS bus = new SupplierBUS();
            var supplier = bus.GetSupplierByPhone(phone);

            if (supplier != null)
            {
                txtSupplierid.Text = supplier.Id;
                txtSupplierName.Text = supplier.Name;
            }
            else
            {
                txtSupplierid.Text = string.Empty;
                txtSupplierName.Text = string.Empty;
            }
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            ProductBUS productBUS = new ProductBUS();
            string nextProductId = productBUS.GenerateNextProductId();

            // Gán mã mới
            txtProductId.Text = nextProductId;

            // Làm sạch các ô nhập liệu
            txtProductName.Clear();
            cbCategory.SelectedIndex = -1;
            cbCalUnit.SelectedIndex = -1;
            nudPriceQuotation.Value = 0;
            nudQuantity.Value = 0;
            nudWarranty.Value = 0;
            txtDescription.Clear();

            // Không cho sửa mã
            txtProductId.Enabled = false;
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();
            if (string.IsNullOrEmpty(name)) return;

            ProductBUS bus = new ProductBUS();
            var product = bus.GetProductByName(name);
            if (product != null)
            {
                txtProductId.Text = product.Id;
                cbCategory.SelectedItem = categoryBUS.GetCategoryNameById(product.CatId);
                cbCalUnit.SelectedItem = product.CalculationUnit;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string name = txtProductName.Text.Trim();
            string unit = cbCalUnit.SelectedItem?.ToString();
            decimal price = nudPriceQuotation.Value;
            int quantity = (int)nudQuantity.Value;

            // Kiểm tra dữ liệu
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (price <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.", "Dữ liệu không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(unit))
            {
                MessageBox.Show("Vui lòng chọn đơn vị tính.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu hợp lệ thì thêm dòng vào DataGridView
            dgv.Rows.Add(
                txtProductId.Text,
                txtProductName.Text,
                cbCategory.SelectedItem?.ToString(),
                cbCalUnit.SelectedItem?.ToString(),
                nudPriceQuotation.Value,
                nudQuantity.Value,
                nudWarranty.Value,
                nudTax.Value,
                txtDescription.Text
            );

            txtProductId.Enabled = true;
            txtProductName.Clear();
            nudPriceQuotation.Value = 0;
            nudTax.Value = 0;
            cbCategory.SelectedIndex = -1;
            nudWarranty.Value = 0;
            nudQuantity.Value = 0;
            cbCalUnit.SelectedIndex = -1;
            txtDescription.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateBeforeSave()) return;

            MessageBox.Show("Dữ liệu hợp lệ, tiến hành lưu hoá đơn.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SaveImportInvoiceToDatabase();

        }

        private void SaveImportInvoiceToDatabase()
        {
            string invoiceId = txtInvoiceId.Text.Trim();
            string supplierId = txtSupplierid.Text.Trim();
            string managerId = txtEmployeeId.Text.Trim();
            string paymentMethod = rdCash.Checked ? ImportInvoiceDTO.Method.CRASH : ImportInvoiceDTO.Method.TRANFER;
            DateTime importDate = dtpImportTime.Value;

            // Kiểm tra đầu vào
            if (string.IsNullOrEmpty(supplierId))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất một sản phẩm vào danh sách.", "Thiếu sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Thêm hóa đơn nhập
            var invoice = new ImportInvoiceDTO
            {
                Id = invoiceId,
                SupId = supplierId,
                ManId = managerId,
                PaymentDate = importDate,
                PaymentMethod = paymentMethod,
                TotalPrice = 0 // tạm thời
            };
            new ImportInvoiceBUS().Insert(invoice);

            long totalInvoice = 0;
            var productBUS = new ProductBUS();
            var categoryBUS = new CategoryBUS();
            var importDetailBUS = new ImportDetailBUS();

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                string productId = row.Cells["Id"].Value.ToString();
                string productName = row.Cells["Name"].Value.ToString();
                string categoryName = row.Cells["Category"].Value.ToString();
                string unit = row.Cells["Unit"].Value.ToString();
                long price = Convert.ToInt64(row.Cells["Price"].Value);
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                int warranty = Convert.ToInt32(row.Cells["Warranty"].Value);
                decimal tax = Convert.ToDecimal(row.Cells["Tax (%)"].Value) / 100m;
                string description = row.Cells["Description"].Value?.ToString();

                // 2. Kiểm tra hoặc thêm danh mục
                string catId = categoryBUS.GetCategoryIdByName(categoryName);
                if (string.IsNullOrEmpty(catId))
                {
                    catId = categoryBUS.GenerateNewCategoryId();
                    categoryBUS.Insert(new CategoryDTO
                    {
                        Id = catId,
                        Name = categoryName,
                        Description = ""
                    });
                }

                // 3. Kiểm tra sản phẩm
                var existingProduct = productBUS.GetProductByName(productName);
                if (existingProduct == null)
                {
                    productBUS.SaveProduct(new ProductDTO
                    {
                        Id = productId,
                        Name = productName,
                        CatId = catId,
                        CalculationUnit = unit,
                        PriceQuotation = (int)price,
                        Quantity = quantity,
                        CustomerWarranty = warranty,
                        Description = description
                    });
                }
                else
                {
                    productBUS.IncreaseQuantity(productId, quantity);
                }

                // 4. Tính tiền & hạn bảo hành
                long lineTotal = (long)(price * quantity * (1 + tax));
                totalInvoice += lineTotal;

                DateTime warrantyDateEnd = warranty > 0
                    ? importDate.AddMonths(warranty)
                    : importDate.AddDays(1); // để tránh vi phạm CHECK constraint

                // 5. Thêm chi tiết hóa đơn
                importDetailBUS.Insert(new ImportDetailDTO
                {
                    Id = invoiceId,
                    ProId = productId,
                    Quantity = quantity,
                    Price = price,
                    Tax = tax,
                    Total = (int)lineTotal,
                    WarrantyDateEnd = warrantyDateEnd
                });
            }

            // 6. Cập nhật tổng tiền
            new ImportInvoiceBUS().UpdateTotal(invoiceId, totalInvoice);

            MessageBox.Show("Lưu hóa đơn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSupplierid.Clear();
            txtSupplierName.Clear();
            txtSupplierPhoneNumber.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xoá sạch các ô nhập liệu trong group Sản phẩm
            txtProductId.Clear();
            txtProductName.Clear();
            cbCategory.SelectedIndex = -1;
            cbCalUnit.SelectedIndex = -1;
            nudPriceQuotation.Value = 0;
            nudQuantity.Value = 0;
            nudWarranty.Value = 0;
            nudTax.Value = 0;
            txtDescription.Clear();

            // Xoá thông tin nhà cung cấp
            txtSupplierid.Clear();
            txtSupplierName.Clear();
            txtSupplierPhoneNumber.Clear();

            // Làm mới DataGridView
            dgv.Rows.Clear();

            // Làm mới lại mã hoá đơn
            txtInvoiceId.Text = importInvoiceBUS.GenerateNewInvoiceId();

            // Đặt lại ngày nhập là ngày hiện tại
            dtpImportTime.Value = DateTime.Now;

            // Đặt lại phương thức thanh toán
            rdCash.Checked = true;
        }
    }
}
