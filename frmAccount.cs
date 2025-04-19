using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmAccount : Form
    {
        private bool searchMode = false;
        DynamicSearch dynamicSearch = null;

        private Account account = null;
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public frmAccount()
        {
            InitializeComponent();
        }
        public frmAccount(Account acc) : this()
        {
            this.account = acc;
        }

        private void LoadForm()
        {
            pnInfo.Enabled = false;
            btnLock.Enabled = false;
            btnAdd.Enabled = false;
            ClearTextBox();
            LoadData();
            dynamicSearch?.Disable();
        }

        private void LoadData()
        {
            dgv.DataSource = LoadDataGridView();
            cbRole.DataSource = LoadComboBox();
            cbRole.SelectedIndex = -1;
        }

        private List<string> LoadComboBox()
        {
            string query = "SELECT DISTINCT Role FROM Employee ORDER BY Role";
            return dbHelper.GetDataForComboBox(query, "Role");
        }
        private DataTable LoadDataGridView()
        {
            // Load data from database
            string query =
                "SELECT " +
                    "emp.EmployeeId AS 'Mã nhân viên', " +
                    "emp.Name AS 'Tên', " +
                    "acc.Username AS 'Tên tài khoản', " +
                    "emp.Role AS 'Chức vụ' " +
                "FROM " +
                    "Account acc " +
                    "JOIN Employee emp ON acc.EmployeeId = emp.EmployeeId " +
                "WHERE emp.EmployeeId NOT IN (SELECT EmployeeId FROM LockedAccount)" +
                "ORDER BY emp.EmployeeId ASC";
            DataTable dt = dbHelper.ExecuteQuery(query);
            return dt;
        }
        private void ClearTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            txtUsername.Clear();
        }
        private void pnButtonEnabler(bool featBtn, bool infoBtn)
        {
            pnFeatureButton.Visible = featBtn;
            pnInfoButton.Visible = infoBtn;
        }
        private void featureButtonEnabler(bool nonCellBtn, bool cellBtn)
        {
            btnAdd.Visible = btnSearch.Visible = nonCellBtn;
            btnLock.Visible = cellBtn;
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            LoadForm();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmChangePW frmChangePW = new frmChangePW();
            frmChangePW.ShowDialog();
        }
        private void btnLock_Click(object sender, EventArgs e)
        {
            string insertDeletedQuery = "INSERT INTO LockedAccount (EmployeeId, Username, Password) SELECT CatagoryID, CatagoryName, Description FROM Catagory WHERE CatagoryID = @ID;";
            string deleteQuery = "DELETE FROM Account WHERE EmployeeId = @ID;";

            // Get a confirmation from the user  
            DialogResult confirmation = MessageBox.Show("Bạn có chắc chắn khoá tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmation == DialogResult.Yes)
            {
                DataTable dt = dbHelper.ExecuteQuery("SELECT * FROM Employee WHERE EmployeeId = @ID", new SqlParameter("@ID", txtID.Text));
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Không thể khóa tài khoản này vì nhân viên vẫn còn trong hệ thống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Insert into DeletedCatagory table  
                    dbHelper.ExecuteNonQuery(insertDeletedQuery, new SqlParameter("@ID", txtID.Text));

                    // Delete from Catagory table  
                    dbHelper.ExecuteNonQuery(deleteQuery, new SqlParameter("@ID", txtID.Text));
                }
            }
            // Reload form  
            LoadForm();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
        // Not done yet
        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!searchMode)
            {
                pnInfo.Enabled = true;
                ClearTextBox();
                txtID.Focus();

                btnAdd.Enabled = false;

                btnSearch.Text = "Huỷ tìm";

                if (dynamicSearch == null)
                {
                    List<Control> searchControls = new List<Control>() { txtID, txtName, txtUsername, cbRole };
                    Dictionary<string, string> columnMappings = new Dictionary<string, string>()
                {
                    {"txtID", "Mã nhân viên" },
                    {"txtName", "Tên" },
                    {"txtUsername", "Tên tài khoản" },
                    {"cbRole", "Chức vụ" }
                };
                    dynamicSearch = new DynamicSearch(searchControls, columnMappings, LoadDataGridView, dgv);
                }
                dynamicSearch?.Enable();


                searchMode = true;
            }
            else
            {
                btnSearch.Text = "Tìm kiếm";
                btnAdd.Enabled = true;

                dgv.DataSource = LoadDataGridView();

                dynamicSearch?.Disable();
                searchMode = false;
            }
        }


        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.CheckInputIsLetter(e);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                int rowIndex = e.RowIndex;
                txtID.Text = dgv.Rows[rowIndex].Cells["Mã nhân viên"].Value.ToString();
                txtName.Text = dgv.Rows[rowIndex].Cells["Tên"].Value.ToString();
                txtUsername.Text = dgv.Rows[rowIndex].Cells["Tên tài khoản"].Value.ToString();
                cbRole.Text = dgv.Rows[rowIndex].Cells["Chức vụ"].Value.ToString();

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadForm();
        }
    }
}
