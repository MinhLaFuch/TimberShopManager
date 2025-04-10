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
    public partial class frmProduct : Form
    {
        #region Properties
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private string catagoryID = "";
        public string CatagoryID
        {
            get { return catagoryID; }
            set { catagoryID = value; }
        }
        public frmProduct()
        {
            InitializeComponent();
        }
        #endregion
        #region Support Methods
        private void loadForm()
        {
            txtID.ReadOnly = true;
            clearTextBox();
            dgvProduct.DataSource = loadData();
            btnEnabler(false, true);
            gbAccInfo.Enabled = false;
            searchEventEnabler(false);
            btnEnabler(false, true);
        }
        private DataTable loadData()
        {
            string query = "SELECT * FROM Product WHERE CatagoryID";
            DataTable dt = dbHelper.ExecuteQuery(query);
            return dt;
        }
        #endregion
        #region Events
        #region Load

        #endregion
        #region Click
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void btnMod_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Text Changed
        #endregion
        #endregion

        private void frmProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
