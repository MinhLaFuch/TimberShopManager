using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using timber_shop_manager.BUS;
using timber_shop_manager.DTO;
using timber_shop_manager.GUI;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmCategory : Form
    {
        #region Properties
        private CategoryBUS bus = new();
        private CategoryDTO selectedCategory = null;
        private EmployeeDTO emp;
        private bool authority;

        private bool searchMode = false;
        private DynamicSearch dynamicSearch = null;

        public frmCategory()
        {
            InitializeComponent();
        }
        public frmCategory(EmployeeDTO emp) : this()
        {
            this.emp = emp;
            authority = (RoleHelper.ConvertToEnum(emp.Role) == RoleEnum.ADMINISTRATOR) || (RoleHelper.ConvertToEnum(emp.Role) == RoleEnum.MANAGER);
        }
        #endregion
        #region Support methods
        private void LoadForm()
        {
            ExitSearchMode();
            ClearTextBox();
            LoadData();
            EnterDefaultMode();
        }
        private void EnterDefaultMode()
        {
            pnInfo.Enabled = false;
            txtId.Enabled = true;

            ButtonVisiblity(true, false, false, false);
            PrepareSearchState(false);
        }
        private void EnterEditMode()
        {
            pnInfo.Enabled = true;
            txtId.Enabled = false;

            ButtonVisiblity(false, false, true, true);
        }
        private void EnterSearchMode()
        {
            searchMode = true;
            pnInfo.Enabled = true;
            ClearTextBox();
            txtId.Enabled = true;
            txtId.Focus();
            ButtonVisiblity(false, false, false, true);
            SetupDynamicSearch();
        }
        private void ButtonVisiblity(bool defaultBtn, bool cellBtn, bool saveBtn, bool cancelBtn)
        {
            btnAdd.Visible = defaultBtn && authority;
            btnSearch.Visible = defaultBtn;
            btnDel.Visible = btnMod.Visible = cellBtn && authority;
            btnViewProducts.Visible = cellBtn;
            btnSave.Visible = saveBtn;
            btnCancel.Visible = cancelBtn;
        }
        private void PrepareSearchState(bool isSearch)
        {
            searchMode = isSearch;
            btnSearch.Text = isSearch ? "Huỷ tìm" : "Tìm kiếm";
            txtId.Enabled = !isSearch;
        }
        private void ClearTextBox()
        {
            txtId.Clear();
            txtName.Clear();
            txtDescription.Clear();
        }
        private void LoadData()
        {
            dgv.DataSource = bus.GetAllCategories();
        }
        private void SetupDynamicSearch()
        {
            if (dynamicSearch != null)
            {
                dynamicSearch.Enable();
                return;
            }

            List<Control> controls = new() { txtId, txtName };
            Dictionary<string, string> mappings = new()
            {
                { "txtId", "Mã danh mục" },
                { "txtName", "Tên" }
            };

            dynamicSearch = new DynamicSearch(
                controls,
                mappings,
                () => bus.GetAllCategories(),
                dgv);
            dynamicSearch.Enable();
        }
        private void ExitSearchMode()
        {
            if (!searchMode) return;
            searchMode = false;
            btnSearch.Text = "Tìm kiếm";

            dynamicSearch?.Disable();
            LoadData();
            txtId.Enabled = true;
        }
        #endregion
        #region Load event
        private void frmCategory_Load(object sender, EventArgs e) => LoadForm();
        #endregion
        #region Button click events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnInfo.Enabled = true;
            string newId = bus.GenerateNewCategoryId();
            txtId.Text = newId;

            txtId.Enabled = false;
            txtName.Enabled = true;
            txtDescription.Enabled = true;

            // B3: Xóa dữ liệu cũ nếu có
            txtName.Clear();
            txtDescription.Clear();

            // B4: Focus vào ô Tên
            txtName.Focus();
            ButtonVisiblity(false, false, true, true);
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            if (selectedCategory != null)
            {
                EnterEditMode();
                txtId.Enabled = false;
                txtName.Focus();
            }
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (selectedCategory != null)
            {
                bus.DeleteCategory(selectedCategory);
                LoadForm();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            EnterSearchMode();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var category = new CategoryDTO(txtId.Text, txtName.Text, txtDescription.Text);
            bus.SaveCategory(category);
            LoadForm();
        }
        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            new frmInvoiceDetail(this, txtId.Text).ShowDialog();
        }
        private void btnCancel_Click(object sender, EventArgs e) => LoadForm();
        #endregion
        #region Cell click event
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgv.Rows[e.RowIndex].Cells["Mã danh mục"].Value == null)
            {
                btnViewProducts.Enabled = false;
                return;
            }

            btnViewProducts.Enabled = true;
            var row = dgv.Rows[e.RowIndex];
            txtId.Text = row.Cells["Mã danh mục"].Value?.ToString();
            txtName.Text = row.Cells["Tên"].Value?.ToString();
            txtDescription.Text = row.Cells["Mô tả"].Value?.ToString();

            selectedCategory = new CategoryDTO(txtId.Text, txtName.Text, txtDescription.Text);
            ButtonVisiblity(true, true, false, false);
        }
        #endregion


    }
}
