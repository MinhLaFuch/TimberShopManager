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
        private Employee.Role role = Employee.Role.UNKNOWN;

        private DatabaseHelper dbHelper = new DatabaseHelper();
        public frmCustomer()
        {
            InitializeComponent();
        }

        public frmCustomer(Employee.Role role) : this()
        {
            this.role = role;
        }
        #endregion
        #region Support methods
        private void FromLoad()
        {
            clearTextBox();
            gbInfo.Enabled = false;
            gbPurchaseHistory.Enabled = false;
            LoadDataGridView();
        }
        private void clearTextBox()
        {
            txtPhoneNumber.Clear();
            txtName.Clear();
            txtAddress.Clear();
        }

        private DataTable LoadDataGridView()
        {
            string query = "SELECT * FROM Customer";

            DataTable dt = dbHelper.ExecuteQuery(query);
            dgv.DataSource = dt;
            return dt;
        }

        private void SuggestCustomer()
        {
            // Kiểm tra xem có TextBox nào trống không
            bool isTextBoxesEmpty = string.IsNullOrEmpty(txtPhoneNumber.Text)
                                    && string.IsNullOrEmpty(txtName.Text)
                                    && string.IsNullOrEmpty(txtAddress.Text);

            if (!isTextBoxesEmpty)
            {
                // Tạo DataView để lọc dữ liệu từ DataGridView
                DataView dv = new DataView(LoadDataGridView());

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
                dgv.DataSource = dv;
            }
            else
            {
                // Nếu tất cả các TextBox trống, hiển thị dữ liệu gốc
                dgv.DataSource = LoadDataGridView();
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
        #endregion
        #region Text Change
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            SuggestCustomer();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SuggestCustomer();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            SuggestCustomer();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FromLoad();
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckInputIsDigit(e);
        }

        public static void CheckInputIsDigit(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true; // Ngừng sự kiện nếu ký tự không hợp lệ
            }
        }
        #endregion
        #endregion
    }
}
