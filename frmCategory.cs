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
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmCategory : Form
    {

        private Category selectedCategory = null;
        private static readonly DatabaseHelper dbHelper = new();
        private Account account = null;
        private bool searchMode = false;
        private DynamicSearch dynamicSearch = null;

        public frmCategory()
        {
            InitializeComponent();
        }
        public frmCategory(Account acc) : this()
        {
            this.account = acc;
        }

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

            btnAdd.Enabled = true;
            btnSearch.Enabled = true;
            btnSave.Enabled = false;
            btnDel.Enabled = false;
            btnMod.Enabled = false;
            btnViewProduct.Enabled = false;

            PrepareSearchState(false);
        }

        private void EnterEditMode()
        {
            pnInfo.Enabled = true;
            txtId.Enabled = false;

            btnSave.Enabled = true;
            btnAdd.Enabled = false;
            btnSearch.Enabled = false;
            btnDel.Enabled = false;
            btnMod.Enabled = false;
            btnViewProduct.Enabled = false;
        }


        private void EnterSearchMode()
        {
            searchMode = true;
            pnInfo.Enabled = true;
            ClearTextBox();
            txtId.Enabled = true;
            txtId.Focus();

            btnSave.Enabled = false;
            btnAdd.Enabled = false;
            btnDel.Enabled = false;
            btnMod.Enabled = false;
            btnViewProduct.Enabled = false;
            btnSearch.Text = "Huỷ tìm";

            SetupDynamicSearch();
        }

        private void PrepareSearchState(bool isSearch)
        {
            searchMode = isSearch;
            btnSearch.Text = isSearch ? "Huỷ tìm" : "Tìm kiếm";
            txtId.ReadOnly = !isSearch;
        }

        private void ClearTextBox()
        {
            txtId.Clear();
            txtName.Clear();
            txtDescription.Clear();
        }

        private void LoadData()
        {
            dgv.DataSource = dbHelper.ExecuteQuery("SELECT Id AS 'Mã danh mục', Name AS 'Tên', Description AS 'Mô tả' FROM Category WHERE IsShow = 1 ORDER BY Id");
        }

        private void frmCategory_Load(object sender, EventArgs e) => LoadForm();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExitSearchMode();
            ClearTextBox();
            EnterEditMode();
            LoadData();

            txtId.Enabled = false;
            string query = "SELECT MAX(Id) FROM Category";
            string currentCode = Convert.ToString(dbHelper.ExecuteScalar(query));
            txtId.Text = Program.GenerateNextCode(currentCode, Category.PREFIX, Category.CODE_LENGTH);

            txtName.Focus();
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
                var confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá danh mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    Category.delete(selectedCategory);
                    LoadForm();
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!searchMode)
            {
                EnterSearchMode();
            }
            else
            {
                LoadForm();
            }
        }
        // Incomplete
        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            frmProduct frmProduct = new frmProduct(account, selectedCategory);
            frmProduct.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var category = new Category(txtId.Text, txtName.Text, txtDescription.Text);
            Category.add(category);
            LoadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e) => LoadForm();

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgv.Rows[e.RowIndex].Cells["Mã danh mục"].Value == null)
                return;

            var row = dgv.Rows[e.RowIndex];
            txtId.Text = row.Cells["Mã danh mục"].Value?.ToString();
            txtName.Text = row.Cells["Tên"].Value?.ToString();
            txtDescription.Text = row.Cells["Mô tả"].Value?.ToString();

            selectedCategory = new Category(txtId.Text, txtName.Text, txtDescription.Text);
            EnableSelectionButtons();
        }

        private void EnableSelectionButtons()
        {
            EnterDefaultMode();
            btnDel.Enabled = true;
            btnMod.Enabled = true;
            btnViewProduct.Enabled = true;
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

            dynamicSearch = new DynamicSearch(controls, mappings, () =>
                dbHelper.ExecuteQuery("SELECT Id AS 'Mã danh mục', Name AS 'Tên', Description AS 'Mô tả' FROM Category WHERE IsShow = 1 ORDER BY Id"),
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
            txtId.ReadOnly = true;
        }
    }
}
