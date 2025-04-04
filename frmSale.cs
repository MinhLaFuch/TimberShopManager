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
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }

        private void grbCustomer_Enter(object sender, EventArgs e)
        {
            frmCustomer frmCustomer = new frmCustomer();
            frmCustomer.ShowDialog();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmSearchProduct frmProduct = new frmSearchProduct();
            frmProduct.ShowDialog();
        }
    }
}
