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

namespace timber_shop_manager
{
    public partial class frmAccount : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        public frmAccount()
        {
            InitializeComponent();
        }
        private void frmAccount_Load(object sender, EventArgs e)
        {
            gbAccInfo.Enabled = false;
            loadData();
        }
        #region Support Method
        private void loadData()
        {
            string query = "select * from Account";
            DataTable dt = dbHelper.ExecuteQuery(query);
            dgvAccount.DataSource = dt;
            for (int i = 0; i < dgvAccount.Columns.Count; i++)
            {
                dgvAccount.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        #endregion
        #region Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmChangePW createAccount = new frmChangePW();
            createAccount.ShowDialog();
        }
        private void btnLock_Click(object sender, EventArgs e)
        {

        }

        // Not done yet
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAccount.Rows.Count > 0)
            {
                int rowIndex = e.RowIndex;
                txtID.Text = dgvAccount.Rows[rowIndex].Cells[0].Value.ToString();
                txtName.Text = dgvAccount.Rows[rowIndex].Cells[1].Value.ToString();
                txtAddress.Text = dgvAccount.Rows[rowIndex].Cells[2].Value.ToString();
                txtUsername.Text = dgvAccount.Rows[rowIndex].Cells[3].Value.ToString();
                dtpDOB.Value = DateTime.Parse(dgvAccount.Rows[rowIndex].Cells[4].Value.ToString());
                cbRole.SelectedItem = dgvAccount.Rows[rowIndex].Cells[5].Value.ToString();
            }
        }
        #endregion

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
