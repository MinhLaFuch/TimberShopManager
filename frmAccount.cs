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

namespace timber_shop_manager
{
    public partial class frmAccount : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public frmAccount()
        {
            InitializeComponent();
        }
        #endregion
        #region Support methods
        private void loadForm()
        {
            pnInfo.Enabled = false;
            clearTextBox();
            btnEnabler(true, false);
            dgv.DataSource = loadData();
        }
        private DataTable loadData()
        {
            string query = "select * from Account acc join Employee emp ON acc.EmployeeId = emp.EmployeeId";
            DataTable dt = dbHelper.ExecuteQuery(query);
            return dt;
        }
        private void clearTextBox()
        {
            txtID.Clear();
            txtName.Clear();
            txtAddress.Clear();
            txtUsername.Clear();
            dtpDOB.Value = DateTime.Now;
            cbRole.SelectedIndex = -1;
        }
        private void btnEnabler(bool featBtn, bool infoBtn)
        {
            btnAdd.Visible = btnLock.Visible = btnSearch.Visible = featBtn;
            btnCancel.Visible = infoBtn;
        }
        #endregion
        #region Events
        #region Load
        private void frmAccount_Load(object sender, EventArgs e)
        {
            loadForm();
        }
        #endregion
        #region Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmChangePW frmChangePW = new frmChangePW();
            this.Hide();
            frmChangePW.ShowDialog();
        }
        // Have not done the lock in database
        private void btnLock_Click(object sender, EventArgs e)
        {
            
        }

        // Not done yet
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        // Need to change
        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count > 0)
            {
                int rowIndex = e.RowIndex;
                txtID.Text = dgv.Rows[rowIndex].Cells[0].Value.ToString();
                txtName.Text = dgv.Rows[rowIndex].Cells[1].Value.ToString();
                txtAddress.Text = dgv.Rows[rowIndex].Cells[2].Value.ToString();
                txtUsername.Text = dgv.Rows[rowIndex].Cells[3].Value.ToString();
                dtpDOB.Value = DateTime.Parse(dgv.Rows[rowIndex].Cells[4].Value.ToString());
                cbRole.SelectedItem = dgv.Rows[rowIndex].Cells[5].Value.ToString();
            }
        }
        #endregion
        #region Text Change
        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion
    }
}
