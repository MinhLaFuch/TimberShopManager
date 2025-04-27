using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;
using System.Runtime.CompilerServices;

namespace timber_shop_manager
{
    public partial class frmSale : Form
    {

        private DatabaseHelper dbHelper = new DatabaseHelper();
        private Account acc;
        private Product selectedProduct = null;
        private DynamicSearch dynamicSearch = null;
        private int selectedRowIndex = -1;
        private decimal originalTotal = 0;
        private decimal displayedTotal = 0;

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
                dgvSale.Columns.Add("ProductId", "Mã Sản Phẩm");
                dgvSale.Columns.Add("ProductName", "Tên Sản Phẩm");
                dgvSale.Columns.Add("Quantity", "Số Lượng");
                dgvSale.Columns.Add("PriceQuotation", "Giá Niêm Yết");
                dgvSale.Columns.Add("Tax", "Thuế");
                dgvSale.Columns.Add("Total", "Tổng Tiền");
                dgvSale.Columns.Add("WarrantyEnd", "Thời Gian Bảo Hành");
                FormatCurrencyColumns(dgvSale, new List<string> { "Giá Niêm Yết", "Thuế", "Tổng Tiền" });
            }

            btnRemoveAll.Enabled = dgvSale.Rows.Count > 0;

            // Reset các điều khiển khác
            nudQuantity.Value = 0; // Đặt lại số lượng về 0

            // Disable các điều khiển (người dùng không thể thay đổi khi chưa tạo phiếu)
            DisableAllControls(true);

            // Thiết lập thông tin mặc định
            txtEmployeeName.Text = name;

            // Tải lại danh sách sản phẩm
            dgvProduct.DataSource = LoadProduct();
            FormatCurrencyColumns(dgvProduct, new List<string> { "Giá Niêm Yết" });
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
            FormLoad();
        }

        private void LoadVoucherComboBox()
        {
            string query = @"
        SELECT Id 
        FROM Voucher 
        WHERE StartDate <= GETDATE() 
          AND EndDate >= GETDATE()";

            List<string> voucherList = dbHelper.GetDataForComboBox(query, "Id");

            cbVoucher.DataSource = voucherList;
            cbVoucher.SelectedIndex = -1; // Không chọn mặc định
        }

        private void DisableAllControls(bool enable)
        {
            btnCancel.Enabled = !enable;
            btnDelete.Enabled = !enable;
            btnCreate.Enabled = !enable;
            btnConfirm.Enabled = !enable;

            pnPurchase.Enabled = pnCustomer.Enabled = !enable;
            btnAddCustomer.Enabled = fpnBtnCustomer.Enabled = pnFindProduct.Enabled = !enable;

            dgvSale.Enabled = !enable;
            dgvProduct.Enabled = !enable;

            btnCreate.Enabled = enable;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Gọi lại FormLoad để khởi tạo lại form khi tạo phiếu mới
            FormLoad();

            // Enable các điều khiển để người dùng có thể thêm thông tin
            DisableAllControls(false);
            btnConfirm.Enabled = false;
            btnDelete.Enabled = dgvSale.Rows.Count > 0;
            btnRemoveAll.Enabled = dgvSale.Rows.Count > 0;

            // Lấy mã hóa đơn mới
            string query = "SELECT MAX(Id) FROM SaleInvoice";
            string currentInvoiceId = Convert.ToString(dbHelper.ExecuteScalar(query));
            string invoiceId = Program.GenerateNextCode(currentInvoiceId, SaleInvoice.PREFIX, SaleInvoice.CODE_LENGTH);
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

            //if (dgvSale.Rows.Count == 0)
            //{
            //    MessageBox.Show("Không có sản phẩm nào trong giỏ hàng.\nVui lòng thêm sản phẩm trước khi in hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //PrintInvoice(txtId.Text, "", txtEmployeeName.Text, txtPhoneNumber.Text, txtCustomerName.Text, txtAddress.Text, dgvSale);
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

            // Kiểm tra xem các cột trong dgvSale đã được tạo chưa, nếu chưa thì tạo mới
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

            // Lấy thông tin sản phẩm
            string productId = selectedProduct.Id;
            string productName = selectedProduct.Name;
            decimal priceQuotation = Convert.ToDecimal(selectedProduct.PriceQuotation);
            decimal quantity = nudQuantity.Value;
            decimal tax = Convert.ToDecimal(SaleInvoice.VAT_TAX); // Thuế VAT 10%
            decimal total = Math.Round(priceQuotation * quantity * (1 + tax), 0, MidpointRounding.AwayFromZero); // Tính tổng tiền đã làm tròn
            DateTime warrantyEnd = DateTime.Now.AddMonths(Convert.ToInt32(selectedProduct.CustomerWarranty)); // Bảo hành

            // Kiểm tra sản phẩm đã có trong dgvSale chưa
            bool productExists = false;
            foreach (DataGridViewRow row in dgvSale.Rows)
            {
                if (row.Cells["ProductId"].Value.ToString() == productId)
                {
                    // Sản phẩm đã tồn tại, cập nhật số lượng và tổng tiền
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
            btnRemoveAll.Enabled = dgvSale.Rows.Count > 0;
            btnDelete.Enabled = dgvSale.Rows.Count > 0;

            // Cập nhật số lượng tồn kho trong dgvProduct
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                if (row.Cells["Mã Sản Phẩm"].Value.ToString() == productId)
                {
                    decimal remainingQuantity = Convert.ToDecimal(row.Cells["Số Lượng"].Value) - quantity;
                    row.Cells["Số Lượng"].Value = remainingQuantity.ToString();
                    break;
                }
            }

            // Cập nhật giới hạn tối đa cho nudQuantity
            decimal currentRemainingQuantity = Convert.ToDecimal(dgvProduct.Rows
                .Cast<DataGridViewRow>()
                .FirstOrDefault(r => r.Cells["Mã Sản Phẩm"].Value.ToString() == productId)?
                .Cells["Số Lượng"].Value ?? 0);

            nudQuantity.Maximum = currentRemainingQuantity;

            // Định dạng lại các cột tiền trong dgvSale
            FormatCurrencyColumns(dgvSale, new List<string> { "Giá Niêm Yết", "Tổng Tiền" });
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

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            // Nếu ô Số điện thoại bị xóa trống, thì xóa luôn các thông tin khách hàng khác
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                ClearCustomerFields();
                return;
            }

            // Nếu ô Số điện thoại có dữ liệu, tìm thông tin khách hàng
            Customer cus = Customer.GetCustomer(txtPhoneNumber.Text);
            if (cus != null)
            {
                txtCustomerName.Text = cus.Name;
                txtAddress.Text = cus.Address;
            }
            else
            {
                // Nếu không tìm thấy khách hàng -> xóa các ô còn lại
                ClearCustomerFields();
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
                Customer newCustomer = new Customer(txtPhoneNumber.Text, txtCustomerName.Text, txtAddress.Text);
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
            btnRemoveAll.Enabled = dgvSale.Rows.Count > 0;
            btnDelete.Enabled = dgvSale.Rows.Count > 0;
        }

        private void PrintInvoice(string invoiceId, string saleId, string saleName, string customerPhone, string customerName, string customerAddress, DataGridView dgvSale)
        {
            if (dgvSale.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = $"Invoice_{DateTime.Now.ToString("yyyyMMddHHmmss")}";
                bool errorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception ex)
                        {
                            errorMessage = true;
                            MessageBox.Show("Không thể ghi dữ liệu vào đĩa: " + ex.Message);
                        }
                    }

                    if (!errorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dgvSale.Columns.Count);
                            pTable.DefaultCell.Padding = 5;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Sử dụng font hỗ trợ tiếng Việt (Ví dụ: VnTime)
                            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
                            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

                            iTextSharp.text.Font titleFont = new iTextSharp.text.Font(bf, 14, 1);
                            iTextSharp.text.Font headerFont = new iTextSharp.text.Font(bf, 11, 1);
                            iTextSharp.text.Font textFont = new iTextSharp.text.Font(bf, 11, 0);

                            // Tiêu đề hóa đơn với màu sắc và font chữ đẹp hơn
                            pTable.AddCell(new PdfPCell(new Phrase("CÔNG TY ABC", titleFont)) { Colspan = dgvSale.Columns.Count, HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase("HÓA ĐƠN BÁN HÀNG", titleFont)) { Colspan = dgvSale.Columns.Count, HorizontalAlignment = Element.ALIGN_CENTER, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase(" ")) { Colspan = dgvSale.Columns.Count, Border = 0 });

                            pTable.AddCell(new PdfPCell(new Phrase("Mã hoá đơn: " + invoiceId, textFont)) { Colspan = dgvSale.Columns.Count, HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase("Ngày lập hóa đơn: " + DateTime.Now.ToString("dd/MM/yyyy"), textFont)) { Colspan = dgvSale.Columns.Count, HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase(" ")) { Colspan = dgvSale.Columns.Count, Border = 0 });

                            pTable.AddCell(new PdfPCell(new Phrase("Mã nhân viên bán hàng: " + saleId, textFont)) { Colspan = dgvSale.Columns.Count, HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase("Tên nhân viên bán hàng: " + saleName, textFont)) { Colspan = dgvSale.Columns.Count, HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase(" ")) { Colspan = dgvSale.Columns.Count, Border = 0 });

                            pTable.AddCell(new PdfPCell(new Phrase("Số điện thoại khách hàng: " + customerPhone, textFont)) { Colspan = dgvSale.Columns.Count, HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase("Tên khách hàng: " + customerName, textFont)) { Colspan = dgvSale.Columns.Count, HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase("Địa chỉ khách hàng: " + customerAddress, textFont)) { Colspan = dgvSale.Columns.Count, HorizontalAlignment = Element.ALIGN_LEFT, Border = 0 });

                            // Thêm một dòng khoảng cách
                            pTable.AddCell(new PdfPCell(new Phrase(" ")) { Colspan = dgvSale.Columns.Count, Border = 0 });

                            // Thêm tiêu đề cột từ DataGridView
                            foreach (DataGridViewColumn col in dgvSale.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText, headerFont));
                                pTable.AddCell(pCell);
                            }

                            // Thêm dữ liệu từ DataGridView vào bảng PDF
                            foreach (DataGridViewRow row in dgvSale.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pTable.AddCell(new Phrase(cell.Value.ToString(), textFont));
                                }
                            }

                            // Tính tổng tiền
                            decimal totalAmount = 0;
                            foreach (DataGridViewRow row in dgvSale.Rows)
                            {
                                totalAmount += Convert.ToDecimal(row.Cells["Total"].Value); // Tổng tiền từ cột Total
                            }

                            // Thêm tổng tiền vào cuối bảng
                            pTable.AddCell(new PdfPCell(new Phrase(" ")) { Colspan = dgvSale.Columns.Count, Border = 0 });

                            //pTable.AddCell(new PdfPCell(new Phrase("Tổng tiền", textFont)) { Colspan = dgvSale.Columns.Count - 1, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase("Tổng tiền: " + totalAmount.ToString(), textFont)) { Colspan = dgvSale.Columns.Count, Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT });

                            // Thêm khu vực ký tên nhân viên bán hàng
                            pTable.AddCell(new PdfPCell(new Phrase(" ")) { Colspan = dgvSale.Columns.Count, Border = 0 });
                            pTable.AddCell(new PdfPCell(new Phrase("Ký tên nhân viên bán hàng", textFont)) { Colspan = dgvSale.Columns.Count, HorizontalAlignment = Element.ALIGN_RIGHT, Border = 0 });

                            // Tạo tệp PDF và lưu vào file
                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A5, 8f, 16f, 16f, 8f);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();
                                document.Add(pTable);
                                document.Close();
                                fileStream.Close();
                            }

                            MessageBox.Show("Hóa đơn đã được in thành công", "Thông báo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xuất hóa đơn: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để in hóa đơn", "Thông báo");
            }
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtProductQuantity.Text = dgvSale.Rows.Count.ToString();
        }

        private void txtProductQuantity_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtProductQuantity.Text) > 0)
            {
                btnConfirm.Enabled = true;
            }
            else
            {
                btnConfirm.Enabled = false;
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            dgvSale.Rows.Clear();
            UpdateTotalAmount();

            FormLoad();

            DisableAllControls(false);
            btnConfirm.Enabled = false;
            btnDelete.Enabled = dgvSale.Rows.Count > 0;
            btnRemoveAll.Enabled = dgvSale.Rows.Count > 0;
            btnRemoveAll.Enabled = dgvSale.Rows.Count > 0;
            btnDelete.Enabled = dgvSale.Rows.Count > 0;
        }

        private void cbVoucher_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra có lựa chọn không
            if (cbVoucher.SelectedItem == null)
                return;

            string selectedVoucherId = cbVoucher.SelectedItem.ToString();

            string query = @"
        SELECT Percentant, Price, StartDate, EndDate 
        FROM Voucher 
        WHERE Id = @VoucherId";

            try
            {
                DataTable voucherTable = dbHelper.ExecuteQuery(query, new SqlParameter("@VoucherId", selectedVoucherId));

                if (voucherTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy mã giảm giá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow voucher = voucherTable.Rows[0];

                decimal discountPercent = voucher["Percentant"] != DBNull.Value ? Convert.ToDecimal(voucher["Percentant"]) : 0m;
                int discountAmount = voucher["Price"] != DBNull.Value ? Convert.ToInt32(voucher["Price"]) : 0;
                DateTime startDate = Convert.ToDateTime(voucher["StartDate"]);
                DateTime endDate = Convert.ToDateTime(voucher["EndDate"]);
                DateTime currentDate = DateTime.Now;

                // Kiểm tra hiệu lực voucher
                if (currentDate < startDate || currentDate > endDate)
                {
                    MessageBox.Show("Mã giảm giá này đã hết hạn hoặc chưa bắt đầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // BẮT ĐẦU tính lại từ originalTotal, không dùng txtTotal.Text
                decimal finalTotal = originalTotal;

                if (discountPercent > 0)
                {
                    // Giảm theo phần trăm
                    finalTotal = finalTotal * (1 - discountPercent);
                }
                else if (discountAmount > 0)
                {
                    // Giảm theo số tiền
                    finalTotal = finalTotal - discountAmount;
                }

                // Đảm bảo không âm
                if (finalTotal < 0)
                {
                    finalTotal = 0;
                }

                // Cập nhật giao diện
                txtTotal.Text = Math.Round(finalTotal, 0).ToString("#,##0");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi áp dụng mã giảm giá.\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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


    }
}
