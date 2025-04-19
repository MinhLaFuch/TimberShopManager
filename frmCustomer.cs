using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmCustomer : Form
    {
        #region Properties
        private Account account;
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public frmCustomer()
        {
            InitializeComponent();
        }

        public frmCustomer(Account acc) : this()
        {
            this.account = acc;
        }
        #endregion
        #region Support methods
        private void FromLoad()
        {
            loadFormBasedOnRole();
            clearTextBox();
            pnInfo.Enabled = false;
            gbPurchaseHistory.Enabled = false;
            dgvCustomer.DataSource = loadCustomerData();
            clearPurchaseHistory();
            pnButtonEnabler(true);
            btnMod.Visible = false;
            searchEventEnabler(false);
        }
        private void loadFormBasedOnRole()
        {
            //bool authority = account.verifyPermission() == Employee.Role.ADMINISTRATOR || account.verifyPermission() == Employee.Role.MANAGER;
            //btnMod.Visible = authority;
        }
        private void clearTextBox()
        {
            txtPhoneNumber.Clear();
            txtName.Clear();
            txtAddress.Clear();
        }
        private void clearPurchaseHistory()
        {
            dgvPurchase.DataSource = null;
            txtInvoiceQuantity.Clear();
            txtCreateDate.Clear();
            txtCategory.Clear();
        }
        private void pnButtonEnabler(bool b)
        {
            pnFeatureButton.Visible = b;
            pnInfoButton.Visible = !b;
        }
        private DataTable loadCustomerData()
        {
            string query = "SELECT * FROM Customer";
            DataTable dt = dbHelper.ExecuteQuery(query);
            return dt;
        }
        private DataTable loadPurchaseHistory(string customerId)
        {
            string query = $"SELECT * FROM Invoice WHERE CustomerId = '{customerId}'";
            DataTable dt = dbHelper.ExecuteQuery(query);
            return dt;
        }
        private void searchEventEnabler(bool b)
        {
            if(b)
            {
                txtPhoneNumber.TextChanged += TxtPhoneNumber_TextChanged;
                txtName.TextChanged += TxtName_TextChanged;
                txtAddress.TextChanged += TxtAddress_TextChanged;
                btnSave.Visible = false;
            }
            else
            {
                txtPhoneNumber.TextChanged -= TxtPhoneNumber_TextChanged;
                txtName.TextChanged -= TxtName_TextChanged;
                txtAddress.TextChanged -= TxtAddress_TextChanged;
                btnSave.Visible = true;
            }
        }

        private void TxtAddress_TextChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TxtName_TextChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TxtPhoneNumber_TextChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void suggest()
        {
            // Kiểm tra xem có TextBox nào trống không
            bool isTextBoxesEmpty = string.IsNullOrEmpty(txtPhoneNumber.Text)
                                    && string.IsNullOrEmpty(txtName.Text)
                                    && string.IsNullOrEmpty(txtAddress.Text);

            if (!isTextBoxesEmpty)
            {
                // Tạo DataView để lọc dữ liệu từ DataGridView
                DataView dv = new DataView(loadCustomerData());

                // Tạo một danh sách điều kiện lọc dựa trên các TextBox có dữ liệu
                List<string> filters = new List<string>();

                if (!string.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    filters.Add($"PhoneNumber LIKE '%{txtPhoneNumber.Text}%'");
                }
                if (!string.IsNullOrEmpty(txtName.Text))
                {
                    filters.Add($"Name LIKE '%{txtName.Text}%'");
                }
                if (!string.IsNullOrEmpty(txtAddress.Text))
                {
                    filters.Add($"Address LIKE '%{txtAddress.Text}%'");
                }

                // Nếu có điều kiện lọc, kết nối chúng bằng OR
                if (filters.Count > 0)
                {
                    dv.RowFilter = string.Join(" OR ", filters);
                }

                // Gán DataSource cho DataGridView
                dgvCustomer.DataSource = dv;
            }
            else
            {
                // Nếu tất cả các TextBox trống, hiển thị dữ liệu gốc
                dgvCustomer.DataSource = loadCustomerData();
            }
        }
        #endregion
        #region Events
        #region Load
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            FromLoad();
        }
        #endregion
        #region Click
        private void btnMod_Click(object sender, EventArgs e)
        {
            pnInfo.Enabled = true;
            clearTextBox();
            txtPhoneNumber.Focus();
            pnButtonEnabler(false);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnInfo.Enabled = true;
            clearTextBox();
            txtPhoneNumber.Focus();
            pnButtonEnabler(false);
            searchEventEnabler(true);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            FromLoad();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }
        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not a header cell
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvCustomer.Rows[e.RowIndex];

                // Extract customer details from the selected row
                txtPhoneNumber.Text = selectedRow.Cells["PhoneNumber"].Value?.ToString();
                txtName.Text = selectedRow.Cells["Name"].Value?.ToString();
                txtAddress.Text = selectedRow.Cells["Address"].Value?.ToString();

                // Load the purchase history for the selected customer
                if (!string.IsNullOrEmpty(txtPhoneNumber.Text))
                {
                    dgvPurchase.DataSource = loadPurchaseHistory(txtPhoneNumber.Text);
                }

                //
            }
        }
        #endregion
        #region Text Change
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            suggest();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            suggest();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            suggest();
        }
        #endregion
        #region Key Press
        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Program.CheckInputIsDigit(e);
        }
        #endregion
        #endregion
    }
}
