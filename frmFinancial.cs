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
    public partial class frmFinancial : Form
    {
        public Account Account { get; }

        public frmFinancial()
        {
            InitializeComponent();
        }

        public frmFinancial(Account account)
        {
            Account = account;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmFinancialReport_Load(object sender, EventArgs e)
        {

        }
    }
}
