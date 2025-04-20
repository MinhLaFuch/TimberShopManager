using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmAttendance : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        private Account account = null;

        private string id = "E001";

        public frmAttendance()
        {
            InitializeComponent();
            realTimeClock.Start();
        }

        public frmAttendance(Account acc) : this()
        {
            this.account = acc;
        }

        private void frmAttendance_Load(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
        }
        private void btnAttend_Click(object sender, EventArgs e)
        {
            
        }

        private void realTimeClock_Tick(object sender, EventArgs e)
        {
            lbRealTime.Text = DateTime.Now.ToLongTimeString();
            realTimeClock.Start();
        }

    }
}