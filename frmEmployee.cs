using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timber_shop_manager
{
    public partial class frmEmployee : Form
    {
        private static DatabaseHelper dbHelper = new DatabaseHelper();
        public frmEmployee()
        {
            InitializeComponent();
        }
        #region Support Method
        private void loadData()
        {
            // Load data from database to DataGridView
            string query = "SELECT * FROM Employee";
            DataTable dt = dbHelper.ExecuteQuery(query);
            dgvEmployee.DataSource = dt;
        }
        private void clearTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            txtIden.Clear();
            txtAddress.Clear();
            cbRole.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
        }
        private void btnEnabler(bool b)
        {
            btnDel.Enabled = b;
            btnViewWorkHour.Enabled = b;
        }
        #endregion
        #region Event
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            txtID.ReadOnly = true;
            clearTextBox();
            btnEnabler(false);
            loadData();
        }
        #region Click Events
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnLock_Click(object sender, EventArgs e)
        {

        }

        private void btnViewWorkHour_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvEmployee.Rows.Count > 0) {
                int rowIndex = e.RowIndex;
                txtID.Text = dgvEmployee.Rows[rowIndex].Cells[""].Value.ToString();
                txtName.Text = dgvEmployee.Rows[rowIndex].Cells[""].Value.ToString();
                txtIden.Text = dgvEmployee.Rows[rowIndex].Cells[""].Value.ToString();
                txtAddress.Text = dgvEmployee.Rows[rowIndex].Cells[""].Value.ToString();
                cbRole.SelectedItem = dgvEmployee.Rows[rowIndex].Cells[""].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(dgvEmployee.Rows[rowIndex].Cells[""].Value);
            }
        #endregion
        #endregion
    }
}
