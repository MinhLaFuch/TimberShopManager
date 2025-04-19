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
using Org.BouncyCastle.Asn1.Ocsp;
using timber_shop_manager.objects;
using static timber_shop_manager.objects.Employee;
namespace timber_shop_manager
{
    public partial class frmProduct : Form
    {
        private Product selectedProduct = null;
        private Account account = null;
        private static DynamicSearch dynamicSearch = null;
        private readonly DatabaseHelper dbHelper = new();

        private bool searchMode = false;

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
            //this.account = acc;
            //this.category = cat;
        }


        private void LoadForm()
        {
            ExitSearchMode();
            ClearInput();
            LoadData();
            EnterDefaultMode();
        }

        private void LoadData()
        {
            dgv.DataSource = LoadDataGridView();
            cbCategory.DataSource = dbHelper.GetDataForComboBox("SELECT DISTINCT Name FROM Category", "Name");
            cbCalUnit.DataSource = dbHelper.GetDataForComboBox("SELECT DISTINCT CalculationUnit FROM Product", "CalculationUnit");
            cbCategory.SelectedIndex = -1;
            cbCalUnit.SelectedIndex = -1;
        }

        private DataTable LoadDataGridView()
        {
            string query = @"
                SELECT 
                    p.Id AS [Mã sản phẩm],
                    c.Name AS [Loại],
                    p.Name AS [Tên sản phẩm],
                    p.CalculationUnit AS [Đơn vị tính],
                    p.PriceQuotation AS [Đơn giá],
                    p.Quantity AS [Số lượng],
                    p.CustomerWarranty AS [Bảo hành (tháng)],
                    p.Description AS [Mô tả]
                FROM Product p
                JOIN Category c ON p.CatId = c.Id
                WHERE p.IsDeleted = 0
                ORDER BY p.Id";

            return dbHelper.ExecuteQuery(query);
        }

        private void ClearInput()
        {
            txtId.Clear();
            txtName.Clear();
            nudPriceQuotation.Value = 0;
            nudWarranty.Value = nudWarranty.Minimum;
            nudQuantity.Value = 0;
            cbCategory.SelectedIndex = -1;
            cbCalUnit.SelectedIndex = -1;
            txtDescription.Clear();
        }

        private void EnterDefaultMode()
        {
            EnableInputFields(false);
            EnableButtons(add: true, search: true, save: false, mod: false, del: false);
        }

        private void EnterEditMode()
        {
            EnableInputFields(true);
            txtId.Enabled = false;
            EnableButtons(add: false, search: false, save: true, mod: false, del: false);
        }

        private void EnterSearchMode()
        {
            searchMode = true;
            ClearInput();
            EnableSearchControlsOnly();
            EnableButtons(add: false, search: true, save: false, mod: false, del: false);
            txtId.Enabled = true;
            btnSearch.Text = "Huỷ tìm"; 
            SetupDynamicSearch();
        }

        private void EnableSearchControlsOnly()
        {
            pnInfo.Enabled = true;

            txtId.Enabled = true;
            txtName.Enabled = true;
            cbCalUnit.Enabled = true;
            txtDescription.Enabled = true;
            cbCategory.Enabled = true;

            nudPriceQuotation.Enabled = false;
            nudQuantity.Enabled = false;
            nudWarranty.Enabled = false;
        }


        private void ExitSearchMode()
        {
            if (!searchMode) return;

            searchMode = false;
            dynamicSearch?.Disable();
            dgv.DataSource = LoadDataGridView();
            txtId.Enabled = false;
            btnSearch.Text = "Tìm kiếm";
        }

        private void EnableInputFields(bool enable)
        {
            pnInfo.Enabled = enable;
            txtId.Enabled = enable;
            txtName.Enabled = enable;
            cbCategory.Enabled = enable;
            cbCalUnit.Enabled = enable;
            nudPriceQuotation.Enabled = enable;
            nudWarranty.Enabled = enable;
            nudQuantity.Enabled = enable;
            txtDescription.Enabled = enable;
        }

        private void EnableButtons(bool add, bool search, bool save, bool mod, bool del)
        {
            btnAdd.Enabled = add;
            btnSearch.Enabled = search;
            btnSave.Enabled = save;
            btnMod.Enabled = mod;
            btnDel.Enabled = del;
        }

        private void SetupDynamicSearch()
        {
            if (dynamicSearch == null)
            {
                List<Control> searchControls = new() { txtId, txtName, cbCalUnit, txtDescription, cbCategory };
                Dictionary<string, string> columnMappings = new()
                    {
                        { "txtId", "Mã sản phẩm" },
                        { "txtName", "Tên sản phẩm" },
                        { "cbCalUnit", "Đơn vị tính" },
                        { "txtDescription", "Mô tả" },
                        { "cbCategory", "Loại" }
                    };

                dynamicSearch = new DynamicSearch(searchControls, columnMappings, LoadDataGridView, dgv);
            }
            dynamicSearch.Enable();
        }


        private void frmProduct_Load(object sender, EventArgs e)
        {
            nudPriceQuotation.Maximum = 1_000_000_000; 
            nudQuantity.Maximum = 10_000_000;         
            nudWarranty.Maximum = 120;
            LoadForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!searchMode)
                EnterSearchMode();
            else
                LoadForm();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null) return;

            var confirm = MessageBox.Show("Bạn có chắc chắn xoá sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                Product.delete(selectedProduct);
                LoadForm();
            }
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            if (selectedProduct != null)
                EnterEditMode();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExitSearchMode();
            ClearInput();
            EnterEditMode();

            string lastId = Convert.ToString(dbHelper.ExecuteScalar("SELECT MAX(Id) FROM Product"));
            txtId.Text = Program.GenerateNextCode(lastId, Product.PREFIX, Product.CODE_LENGTH);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Dictionary<Control, Label> controlLabelPairs = new()
            {
                { txtId, lbId },
                { txtName, lbName },
                { cbCategory, lbCategory },
                { cbCalUnit, new Label { Text = "Đơn vị tính" } }
            };

            if (!InputValidator.ValidateNotEmpty(controlLabelPairs))
                return;

            if (nudPriceQuotation.Value <= 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudPriceQuotation.Focus();
                return;
            }

            Product product = new Product(
                txtId.Text,
                Category.getId(cbCategory.Text),
                txtName.Text,
                cbCalUnit.Text,
                nudPriceQuotation.Value.ToString(),
                nudQuantity.Value.ToString(),
                nudWarranty.Value.ToString(),
                txtDescription.Text);

            Product.add(product);
            LoadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e) => LoadForm();

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgv.Rows[e.RowIndex].Cells["Mã sản phẩm"].Value == null)
            {
                EnterDefaultMode();
                return;
            }

            var row = dgv.Rows[e.RowIndex];
            txtId.Text = row.Cells["Mã sản phẩm"].Value?.ToString();
            txtName.Text = row.Cells["Tên sản phẩm"].Value?.ToString();
            cbCalUnit.Text = row.Cells["Đơn vị tính"].Value?.ToString();
            nudPriceQuotation.Value = Convert.ToDecimal(row.Cells["Đơn giá"].Value);
            nudQuantity.Value = Convert.ToDecimal(row.Cells["Số lượng"].Value);
            nudWarranty.Value = Convert.ToDecimal(row.Cells["Bảo hành (tháng)"].Value);
            txtDescription.Text = row.Cells["Mô tả"].Value?.ToString();
            cbCategory.Text = row.Cells["Loại"].Value?.ToString();

            selectedProduct = new Product(
                txtId.Text,
                Category.getId(cbCategory.Text),
                txtName.Text,
                cbCalUnit.Text,
                nudPriceQuotation.Value.ToString(),
                nudQuantity.Value.ToString(),
                nudWarranty.Value.ToString(),
                txtDescription.Text);

            EnableButtons(add: true, search: true, save: false, mod: true, del: true);
        }
        
    }
}
