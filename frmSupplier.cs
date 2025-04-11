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
using static timber_shop_manager.objects.Employee;

namespace timber_shop_manager
{
    public partial class frmSupplier : Form
    {
        private DynamicSearch dynamicSearch = null;
        private Supplier selectedSupplier = null;

        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public frmSupplier()
        {
            InitializeComponent();
        }
        #endregion

        #region Support Methods
        private void loadForm()
        {
            dynamicSearch?.Disable();

            clearTextBox();
            dgvSupplier.DataSource = loadData();

            gbInfo.Enabled = false;
            txtID.Enabled = false;
            btnEnabler(false, true);
        }
        private DataTable loadData()
        {
            string sql = "SELECT * FROM Supplier";
            DataTable dt = dbHelper.ExecuteQuery(sql);
            return dt;
        }
        private void btnEnabler(bool featBtn, bool initBtn)
        {
            btnDel.Enabled = btnMod.Enabled = featBtn;
            btnAdd.Enabled = btnSearch.Enabled = initBtn;
        }
        private void clearTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtWebsite.Clear();
        }

        #endregion
        #region Events
        #region Load
        private void frmSupplier_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        #endregion
        #region Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            dynamicSearch?.Disable();
            gbInfo.Enabled = true;
            clearTextBox();

            string lastCode = Convert.ToString(dbHelper.ExecuteScalar("SELECT TOP 1 SupplierId FROM Supplier ORDER BY SupplierId DESC"));
            txtID.Text = Program.GenerateNextCode(lastCode, Supplier.PREFIX, Supplier.CODE_LENGTH);

            txtName.Focus();
            btnEnabler(false, false);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show($"Bạn có chắc chắn xóa Nhà cung cấp này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                Supplier.delete(selectedSupplier);
            }

            loadForm();
        }
        private void btnMod_Click(object sender, EventArgs e)
        {
            dynamicSearch?.Disable();
            gbInfo.Enabled = true;
            txtName.Focus();
            btnEnabler(false, false);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            gbInfo.Enabled = true;
            txtID.Enabled = true;
            btnSave.Enabled = false;
            txtID.Focus();
            
            if (dynamicSearch == null)
            {
                List<Control> searchControls = new List<Control> {txtID, txtName, txtPhoneNumber, txtAddress, txtEmail, txtWebsite};
                Dictionary<string, string> columnMappings = new Dictionary<string, string>
                {
                    { "txtID", "SupplierID" },
                    { "txtName", "Name" },
                    { "txtPhoneNumber", "ContactNumber" },
                    { "txtAddress", "Address" },
                    { "txtEmail", "Email" },
                    { "txtWebsite", "Website" }
                }; 

                dynamicSearch = new DynamicSearch(searchControls, columnMappings, loadData, dgvSupplier);
            }

            dynamicSearch.Enable();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier(txtID.Text, txtName.Text, txtAddress.Text, txtPhoneNumber.Text, txtEmail.Text, txtWebsite.Text);

            Supplier.add(supplier);
            // Reload form
            loadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadForm();
        }

        #endregion
        #region Key Press
        // Need to do input validation for email and website?
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CheckInputIsDigit(e);
        }
        #endregion
        #endregion

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dynamicSearch?.Disable();
            if (e.RowIndex >= 0 && dgvSupplier.Rows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvSupplier.Rows[e.RowIndex];

                // Fill all info to groupbox
                txtID.Text = row.Cells["SupplierID"].Value?.ToString();
                txtName.Text = row.Cells["Name"].Value?.ToString();
                txtPhoneNumber.Text = row.Cells["ContactNumber"].Value?.ToString();
                txtAddress.Text = row.Cells["Address"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtWebsite.Text = row.Cells["Website"].Value?.ToString();

                selectedSupplier = new Supplier(txtID.Text, txtName.Text, txtAddress.Text, txtPhoneNumber.Text, txtEmail.Text, txtWebsite.Text);

                // Enable buttons
                btnEnabler(true, true);
            }
        }
    }
}
