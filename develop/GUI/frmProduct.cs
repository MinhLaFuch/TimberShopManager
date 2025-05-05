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
using timber_shop_manager.BUS;
using timber_shop_manager.DTO;
using timber_shop_manager.objects;
namespace timber_shop_manager
{
    public partial class frmProduct : Form
    {
        private EmployeeDTO emp;
        private bool authority;

        private static DynamicSearch dynamicSearch = null;
        private readonly DatabaseHelper dbHelper = new();

        private readonly ProductBUS bus = new();
        private ProductDTO selectedProduct = null;

        private readonly CategoryBUS categoryBUS = new();

        private bool searchMode = false;

        public frmProduct()
        {
            InitializeComponent();
        }

        public frmProduct(EmployeeDTO emp) : this()
        {
            this.emp = emp;
            authority = (RoleHelper.ConvertToEnum(emp.Role) == RoleEnum.ADMINISTRATOR) || (RoleHelper.ConvertToEnum(emp.Role) == RoleEnum.MANAGER);
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
            dgv.DataSource = bus.GetAllProducts();
            cbCategory.DataSource = bus.GetCategories();
            cbCalUnit.DataSource = bus.GetUnits();
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
            EnableButtons(featureBtn: true, cellBtn: false, saveBtn: false, cancelBtn: false);
        }

        private void EnterEditMode()
        {
            EnableInputFields(true);
            txtId.Enabled = false;
            EnableButtons(featureBtn: false, cellBtn: false, saveBtn: true, cancelBtn: true);
        }

        private void EnterSearchMode()
        {
            searchMode = true;
            ClearInput();
            EnableSearchControlsOnly();
            EnableButtons(featureBtn: false, cellBtn: false, saveBtn: false, cancelBtn: true);
            txtId.Enabled = true;
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

        private void EnableButtons(bool featureBtn, bool cellBtn, bool saveBtn, bool cancelBtn)
        {
            btnAdd.Visible = featureBtn && authority;
            btnSearch.Visible = featureBtn;
            btnSave.Visible = saveBtn && authority;
            btnMod.Visible = btnDel.Visible = cellBtn && authority;
            btnCancel.Visible = cancelBtn;
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
                EnterSearchMode();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null) return;
            var confirm = MessageBox.Show("Bạn có chắc chắn xoá sản phẩm này không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                bus.DeleteProduct(selectedProduct.Id);
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
            txtId.Text = bus.GenerateNextProductId();
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

            ProductDTO dto = new ProductDTO(
                txtId.Text,
                categoryBUS.GetCategoryIdByName(cbCategory.Text),
                txtName.Text,
                cbCalUnit.Text,
                (double)nudPriceQuotation.Value,
                (int)nudQuantity.Value,
                (int)nudWarranty.Value,
                txtDescription.Text
            );

            bus.SaveProduct(dto);
            LoadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e) => LoadForm();

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgv.Rows[e.RowIndex].Cells["Mã sản phẩm"].Value == null)
                return;

            var row = dgv.Rows[e.RowIndex];
            selectedProduct = new ProductDTO(
                txtId.Text = row.Cells["Mã sản phẩm"].Value?.ToString(),
                categoryBUS.GetCategoryIdByName(cbCategory.Text = row.Cells["Loại"].Value?.ToString()),
                txtName.Text = row.Cells["Tên sản phẩm"].Value?.ToString(),
                cbCalUnit.Text = row.Cells["Đơn vị tính"].Value?.ToString(),
                (double)(nudPriceQuotation.Value = Convert.ToDecimal(row.Cells["Đơn giá"].Value)),
                (int)(nudQuantity.Value = Convert.ToDecimal(row.Cells["Số lượng"].Value)),
                (int)(nudWarranty.Value = Convert.ToDecimal(row.Cells["Bảo hành (tháng)"].Value)),
                txtDescription.Text = row.Cells["Mô tả"].Value?.ToString()
            );

            EnableButtons(featureBtn: true, cellBtn: true, saveBtn: false, cancelBtn: false);
        }

    }
}
