using System.Data;
using timber_shop_manager.objects;
using timber_shop_manager.DTO;
using timber_shop_manager.BUS;

namespace timber_shop_manager
{
    public partial class frmSale : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private EmployeeDTO emp;
        private ProductDTO selectedProduct = null; 
        private DynamicSearch dynamicSearch = null;
        private int selectedRowIndex = -1;
        private decimal originalTotal = 0;
        private decimal displayedTotal = 0;

        private string name, id = "E017";

        private readonly CustomerBUS customerBUS = new CustomerBUS();
        private readonly SaleBUS saleBUS = new SaleBUS();
        private readonly ProductBUS productBUS = new ProductBUS();
        private readonly VoucherBUS voucherBUS = new VoucherBUS();
        private bool isVoucherLoading = false;
        public frmSale()
        {
            InitializeComponent();
        }

        public frmSale(EmployeeDTO emp) : this()
        {
            this.emp = emp;
            name = emp.Name;
            id = emp.Id;
        }
        #endregion
        #region Support methods
        private void InitializeOriginalTotal()
        {
            if (decimal.TryParse(txtTotal.Text, out decimal total))
            {
                originalTotal = total;
            }
            else
            {
                originalTotal = 0;
            }
        }

        private void ClearCustomerFields()
        {
            txtCustomerName.Clear();
            txtAddress.Clear();
        }

        private void FormLoad()
        {
            // Làm sạch các giá trị trong các textbox
            txtId.Clear();
            txtEmployeeName.Clear();
            txtPhoneNumber.Clear();
            txtCustomerName.Clear();
            txtAddress.Clear();
            txtProductName.Clear();
            txtTotal.Text = "0";
            txtProductQuantity.Text = "0";

            InitializeOriginalTotal();

            // Làm sạch dgvSale (xóa các sản phẩm đã thêm vào)
            dgvSale.Rows.Clear();

            // Kiểm tra và tạo lại các cột nếu chưa có
            if (dgvSale.Columns.Count == 0)
            {
                dgvSale.Columns.Add("ProductId", "Mã sản phẩm");
                dgvSale.Columns.Add("ProductName", "Tên sản phẩm");
                dgvSale.Columns.Add("Quantity", "Số lượng");
                dgvSale.Columns.Add("PriceQuotation", "Đơn giá");
                dgvSale.Columns.Add("Tax", "Thuế");
                dgvSale.Columns.Add("Total", "Tổng Tiền");
                dgvSale.Columns.Add("WarrantyEnd", "Bảo hành (tháng)");
                FormatCurrencyColumns(dgvSale, new List<string> { "Đơn giá", "Thuế", "Tổng Tiền" });
            }

            private void UpdateTotalAndQty()
            {
                decimal totalAmount = 0;
                int totalQty = 0;
            
                foreach (DataGridViewRow row in dgvSale.Rows)
                {
                    if (row.Cells["colTotal"].Value != null && row.Cells["colQty"].Value != null)
                    {
                        totalAmount += Convert.ToDecimal(row.Cells["colTotal"].Value);
                        totalQty += Convert.ToInt32(row.Cells["colQty"].Value);
                    }
                }
            
                lblTotalAmount.Text = totalAmount.ToString("N0");
                lblTotalQty.Text = totalQty.ToString();
            }


            btnRemoveAll.Visible = dgvSale.Rows.Count > 0;

            // Reset các điều khiển khác
            nudQuantity.Value = 0; // Đặt lại Số lượng về 0

            // Disable các điều khiển (người dùng không thể thay đổi khi chưa tạo phiếu)
            DisableAllControls(true);

            // Thiết lập thông tin mặc định
            txtEmployeeName.Text = name;

            // Tải lại danh sách sản phẩm
            dgvProduct.DataSource = LoadProduct();
            FormatCurrencyColumns(dgvProduct, new List<string> { "Đơn giá" });
            LoadVoucherComboBox();

            // Cập nhật Autocomplete cho các textbox
            txtPhoneNumber.AutoCompleteCustomSource = LoadAutoCompleteDataForCustomer();
            txtPhoneNumber.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtPhoneNumber.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtProductName.AutoCompleteCustomSource = LoadAutoCompleteDataForProduct();
            txtProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            return productBUS.GetAllProducts();
        }

        private AutoCompleteStringCollection LoadAutoCompleteDataForCustomer()
        {
            var autoCompleteCollection = new AutoCompleteStringCollection();

            List<string> items = customerBUS.GetAllCustomerPhoneNumbers();

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
        private void LoadVoucherComboBox()
        {
            try
            {
                isVoucherLoading = true;

                DataTable voucherCodes = voucherBUS.GetVoucherCodesOnly();

                if (voucherCodes == null || voucherCodes.Rows.Count == 0)
                {
                    cbVoucher.DataSource = null;
                    cbVoucher.Items.Clear();
                }
                else
                {
                    cbVoucher.DataSource = voucherCodes;
                    cbVoucher.DisplayMember = "Id";
                    cbVoucher.ValueMember = "Id";
                    cbVoucher.SelectedIndex = -1; // Don't select any by default
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vouchers: " + ex.Message);
            }
            finally
            {
                isVoucherLoading = false;
            }
        }

        private void DisableAllControls(bool enable)
        {
            btnCancel.Visible = !enable;
            btnDelete.Visible = !enable;
            btnCreate.Visible = !enable;
            btnConfirm.Visible = !enable;

            pnPurchase.Enabled = pnCustomer.Enabled = !enable;
            btnAddCustomer.Visible = fpnBtnCustomer.Enabled = pnFindProduct.Enabled = !enable;

            dgvSale.Enabled = !enable;
            dgvProduct.Enabled = !enable;

            btnCreate.Visible = enable;

        }
        private void UpdateTotalDisplay()
        {
            txtTotal.Text = Math.Round(originalTotal, 0).ToString("#,##0");
            txtProductQuantity.Text = dgvSale.Rows.Count.ToString();
        }
        private void UpdateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in dgvSale.Rows)
            {
                totalAmount += Convert.ToDecimal(row.Cells["Total"].Value);
            }

            originalTotal = totalAmount;
        }
        private void FormatCurrencyColumns(DataGridView dgv, List<string> columnNames)
        {
            foreach (string columnName in columnNames)
            {
                if (dgv.Columns.Contains(columnName))
                {
                    dgv.Columns[columnName].DefaultCellStyle.Format = "#,##0"; // Chỉ hiển thị số nguyên, dấu phẩy hàng nghìn
                    dgv.Columns[columnName].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight; // Căn phải
                }
            }
        }
        #endregion
        #region Load event
        private void frmSale_Load(object sender, EventArgs e)
        {
            FormLoad();
        }
        #endregion
        #region Button click
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Kiểm tra giỏ hàng có ít nhất một sản phẩm
            if (dgvSale.Rows.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong giỏ hàng.\nVui lòng thêm sản phẩm trước khi lập hóa đơn.",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra thông tin khách hàng bằng InputValidator
            bool isCustomerInfoValid = InputValidator.ValidateNotEmpty(new Dictionary<Control, Label>
            {
                { txtPhoneNumber, lbPhoneNumber },
                { txtCustomerName, lbCustomerName },
                { txtAddress, lbAddress }
            });

            if (!isCustomerInfoValid)
            {
                // Nếu thiếu thông tin, đã có MessageBox trong InputValidator rồi
                return;
            }

            var invoice = new SaleInvoiceDTO(
                txtId.Text,
                txtPhoneNumber.Text,
                id,
                DateTime.Now,
                originalTotal,
                rdCash.Checked ? SaleInvoiceDTO.Method.CRASH : SaleInvoiceDTO.Method.TRANFER
            );

            var details = new List<SaleDetailDTO>();
            foreach (DataGridViewRow row in dgvSale.Rows)
            {
                details.Add(new SaleDetailDTO(
                    invoice.Id,
                    row.Cells["ProductId"].Value.ToString(),
                    Convert.ToInt32(row.Cells["Quantity"].Value),
                    Convert.ToDecimal(row.Cells["PriceQuotation"].Value),
                    SaleInvoiceDTO.VAT_TAX,
                    Convert.ToDecimal(row.Cells["Total"].Value),
                    DateTime.ParseExact(row.Cells["WarrantyEnd"].Value.ToString(), "dd/MM/yyyy", null)
                ));
            }

            decimal totalBeforeDiscount = originalTotal;
            decimal totalAfterDiscount = 0;
            decimal discountValue = 0;
            string voucherCode = cbVoucher.SelectedValue?.ToString();

            VoucherDTO voucher = null;
            if (!string.IsNullOrWhiteSpace(voucherCode))
            {
                voucher = voucherBUS.GetVoucherById(voucherCode);
                if (voucher != null && DateTime.Now >= voucher.StartDate && DateTime.Now <= voucher.EndDate)
                {
                    if (voucher.Percentant > 0)
                        discountValue = Math.Round(totalBeforeDiscount * voucher.Percentant, 0);
                    else if (voucher.Price > 0)
                        discountValue = voucher.Price;
                }
            }

            totalAfterDiscount = totalBeforeDiscount - discountValue;
            if (totalAfterDiscount < 0) totalAfterDiscount = 0;

            try
            {
                saleBUS.CreateInvoice(invoice, details, voucherCode);
                MessageBox.Show("Hóa đơn đã được lưu thành công vào cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Do not proceed to printing if saving fails
            }

            // Call with all required arguments
            saleBUS.PrintInvoice(invoice, details, totalBeforeDiscount, voucherCode, discountValue, totalAfterDiscount);
            FormLoad();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem sản phẩm đã được chọn chưa và Số lượng có hợp lệ không
            if (selectedProduct == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm!");
                return;
            }

            if (nudQuantity.Value <= 0)
            {
                MessageBox.Show("Vui lòng nhập Số lượng hợp lệ!");
                return;
            }

            // Kiểm tra xem các cột trong dgvSale đã được tạo chưa, nếu chưa thì tạo mới
            if (dgvSale.Columns.Count == 0)
            {
                dgvSale.Columns.Add("ProductId", "Mã sản phẩm");
                dgvSale.Columns.Add("ProductName", "Tên sản phẩm");
                dgvSale.Columns.Add("Quantity", "Số lượng");
                dgvSale.Columns.Add("PriceQuotation", "Đơn giá");
                dgvSale.Columns.Add("Tax", "Thuế");
                dgvSale.Columns.Add("Total", "Tổng Tiền");
                dgvSale.Columns.Add("WarrantyEnd", "Bảo hành (tháng)");
            }

            // Lấy thông tin sản phẩm
            string productId = selectedProduct.Id;
            string productName = selectedProduct.Name;
            decimal priceQuotation = Convert.ToDecimal(selectedProduct.PriceQuotation);
            decimal quantity = nudQuantity.Value;
            decimal tax = Convert.ToDecimal(SaleInvoiceDTO.VAT_TAX); // Thuế VAT 10%
            decimal total = Math.Round(priceQuotation * quantity * (1 + tax), 0, MidpointRounding.AwayFromZero); // Tính tổng tiền đã làm tròn
            DateTime warrantyEnd = DateTime.Now.AddMonths(Convert.ToInt32(selectedProduct.CustomerWarranty)); // Bảo hành

            // Kiểm tra sản phẩm đã có trong dgvSale chưa
            bool productExists = false;
            foreach (DataGridViewRow row in dgvSale.Rows)
            {
                if (row.Cells["ProductId"].Value.ToString() == productId)
                {
                    // Sản phẩm đã tồn tại, cập nhật Số lượng và tổng tiền
                    decimal existingQuantity = Convert.ToDecimal(row.Cells["Quantity"].Value);
                    decimal newQuantity = existingQuantity + quantity;
                    decimal newTotal = Math.Round(priceQuotation * newQuantity * (1 + tax), 0, MidpointRounding.AwayFromZero);

                    row.Cells["Quantity"].Value = newQuantity;
                    row.Cells["Total"].Value = newTotal.ToString("#,##0");

                    UpdateTotalAmount();
                    productExists = true;
                    break;
                }
            }

            // Nếu sản phẩm chưa có, thêm mới vào dgvSale
            if (!productExists)
            {
                int rowIndex = dgvSale.Rows.Add(
                    productId,
                    productName,
                    quantity,
                    priceQuotation,
                    tax.ToString("P0"),
                    total,
                    warrantyEnd.ToString("dd/MM/yyyy")
                );

                // Định dạng các cột tiền ngay khi thêm sản phẩm
                dgvSale.Rows[rowIndex].Cells["PriceQuotation"].Value = priceQuotation.ToString("#,##0");
                dgvSale.Rows[rowIndex].Cells["Tax"].Value = tax.ToString("P0");
                dgvSale.Rows[rowIndex].Cells["Total"].Value = total.ToString("#,##0");
            }

            // Cập nhật tổng tiền trong hóa đơn
            UpdateTotalAmount();
            UpdateTotalDisplay();

            // Enable nút xoá, xoá tất cả
            btnRemoveAll.Visible = dgvSale.Rows.Count > 0;
            btnDelete.Visible = dgvSale.Rows.Count > 0;

            // Cập nhật Số lượng tồn kho trong dgvProduct
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                if (row.Cells["Mã sản phẩm"].Value.ToString() == productId)
                {
                    decimal remainingQuantity = Convert.ToDecimal(row.Cells["Số lượng"].Value) - quantity;
                    row.Cells["Số lượng"].Value = remainingQuantity.ToString();
                    break;
                }
            }

            // Cập nhật giới hạn tối đa cho nudQuantity
            decimal currentRemainingQuantity = Convert.ToDecimal(dgvProduct.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["Mã sản phẩm"].Value.ToString() == productId)?
                .Cells["Số lượng"].Value ?? 0);

            nudQuantity.Maximum = currentRemainingQuantity;

            // Định dạng lại các cột tiền trong dgvSale
            FormatCurrencyColumns(dgvSale, new List<string> { "Đơn giá", "Tổng tiền" });
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Gọi lại FormLoad để khởi tạo lại form khi tạo phiếu mới
            FormLoad();

            // Enable các điều khiển để người dùng có thể thêm thông tin
            DisableAllControls(false);
            btnConfirm.Visible = false;
            btnDelete.Visible = dgvSale.Rows.Count > 0;
            btnRemoveAll.Visible = dgvSale.Rows.Count > 0;

            txtId.Text = saleBUS.GenerateNextInvoiceId();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGroupBoxCustomer();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
        if (dgvSale.CurrentRow != null)
            {
                int rowIndex = dgvSale.CurrentRow.Index;
                if (rowIndex >= 0 && rowIndex < dgvSale.Rows.Count)
                {
                    // Trừ tổng tiền và số lượng sản phẩm
                    try
                    {
                        decimal price = Convert.ToDecimal(dgvSale.Rows[rowIndex].Cells["colTotal"].Value);
                        int quantity = Convert.ToInt32(dgvSale.Rows[rowIndex].Cells["colQty"].Value);
        
                        // Xóa hàng
                        dgvSale.Rows.RemoveAt(rowIndex);
        
                        // Cập nhật lại tổng tiền và số lượng
                        UpdateTotalAndQty();
        
                        // Cập nhật trạng thái nút
                        UpdateDeleteButtonsVisibility();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message);
                    }
                }
            }
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            bool isValid = InputValidator.ValidateNotEmpty(new Dictionary<Control, Label>
            {
                { txtPhoneNumber, lbPhoneNumber },
                { txtCustomerName, lbCustomerName },
                { txtAddress, lbAddress }
            });

            if (isValid)
            {
                var newCustomer = new CustomerDTO
                {
                    PhoneNumber = txtPhoneNumber.Text,
                    Name = txtCustomerName.Text,
                    Address = txtAddress.Text
                };
                customerBUS.SaveCustomer(newCustomer);
                MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            dgvSale.Rows.Clear();
            UpdateTotalAmount();
        }
        #endregion
        #region Value changed event
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                ClearCustomerFields();
                return;
            }

            var customer = customerBUS.GetCustomer(txtPhoneNumber.Text);
            if (customer != null)
            {
                txtCustomerName.Text = customer.Name;
                txtAddress.Text = customer.Address;
            }
            else
            {
                ClearCustomerFields();
            }
        }
        private void cbVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isVoucherLoading || cbVoucher.SelectedIndex == -1)
                return;

            string voucherId = cbVoucher.SelectedValue?.ToString();
            if (string.IsNullOrWhiteSpace(voucherId))
                return;

            // Use BUS to fetch voucher info (clean 3-tier)
            VoucherDTO voucher = voucherBUS.GetVoucherById(voucherId);
            if (voucher == null)
            {
                MessageBox.Show("Không tìm thấy mã giảm giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check date validity
            DateTime now = DateTime.Now;
            if (now < voucher.StartDate || now > voucher.EndDate)
            {
                MessageBox.Show("Mã giảm giá này đã hết hạn hoặc chưa bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Apply discount
            decimal finalTotal = originalTotal;

            if (voucher.Percentant > 0)
            {
                finalTotal *= (1 - voucher.Percentant);
            }
            else if (voucher.Price > 0)
            {
                finalTotal -= voucher.Price;
            }

            if (finalTotal < 0)
                finalTotal = 0;

            txtTotal.Text = Math.Round(finalTotal, 0).ToString("#,##0");
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtProductQuantity.Text = dgvSale.Rows.Count.ToString();
        }

        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtProductQuantity.Text) > 0)
            {
                btnConfirm.Visible = true;
            }
            else
            {
                btnConfirm.Visible = false;
            }
        }
        #endregion
        #region KeyPress events
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e) => InputValidator.CheckInputIsDigit(e);
        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e) => InputValidator.CheckInputIsLetter(e);
        #endregion
        #region Cell click event
        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamicSearch?.Disable();

            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvProduct.Rows[e.RowIndex];

                string productId = Convert.ToString(selectedRow.Cells["Mã sản phẩm"].Value);
                string productName = Convert.ToString(selectedRow.Cells["Tên sản phẩm"].Value);
                string unit = Convert.ToString(selectedRow.Cells["Đơn vị tính"].Value);
                string price = Convert.ToString(selectedRow.Cells["Đơn giá"].Value);
                string quantity = Convert.ToString(selectedRow.Cells["Số lượng"].Value);
                string warranty = Convert.ToString(selectedRow.Cells["Bảo hành (tháng)"].Value);
                string description = Convert.ToString(selectedRow.Cells["Mô tả"].Value);

                txtProductName.Text = productName;
                lbUnit.Text = unit;

                selectedProduct = new ProductDTO
                {
                    Id = productId,
                    Name = productName,
                    CalculationUnit = unit,
                    PriceQuotation = Convert.ToDouble(price),
                    Quantity = Convert.ToInt32(quantity),
                    CustomerWarranty = Convert.ToInt32(warranty),
                    Description = description
                };

                nudQuantity.Maximum = selectedProduct.Quantity;
                nudQuantity.Value = selectedProduct.Quantity > 0 ? 1 : 0;
            }
        }
        private void dgvSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedRowIndex = e.RowIndex;
                btnDelete.Visible = true;
            }
        }
        #endregion
        #region Textbox click event
        private void txtProductName_Click(object sender, EventArgs e)
        {
            if (dynamicSearch == null)
            {
                dynamicSearch = new DynamicSearch(
                    new List<Control> { txtProductName },  // Các điều khiển tìm kiếm, ở đây chỉ có ComboBox
                    new Dictionary<string, string>
                    {
                        { "txtProductName", "Tên sản phẩm" }  // Ánh xạ tên điều khiển với tên cột trong DataTable
                    },
                    LoadProduct,
                    dgvProduct
                );
            }
            dynamicSearch?.Enable();
        }
        #endregion
    }
}
