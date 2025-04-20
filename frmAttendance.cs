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

        private string id = "E009";

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
            lbEmployeeId.Text = id;
            pnFromTo.Enabled = false;

            dtpTo.MaxDate = DateTime.Now.AddDays(1);

            dtpFrom.Value = DateTime.Now;

            LoadAttendance();
        }

        private void LoadAttendance()
        {
            string query = "SELECT CAST(Date AS DATE) AS Day, CONVERT(VARCHAR, CAST(Date AS TIME), 108) AS Time, Review FROM Attendance WHERE Id = @id ORDER BY Date DESC";
            var dt = dbHelper.ExecuteQuery(query, new SqlParameter("@id", id));

            dgv.DataSource = dt;

            dgv.Columns["Day"].HeaderText = "Ngày";
            dgv.Columns["Time"].HeaderText = "Giờ (Thời gian)";
            dgv.Columns["Review"].HeaderText = "Trạng thái";

            dgv.Columns["Day"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv.Columns["Time"].DefaultCellStyle.Format = "";
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;

            Attendance attendance = new Attendance(this.id, currentDateTime);
            attendance.add();

            LoadAttendance();
        }

        private void realTimeClock_Tick(object sender, EventArgs e)
        {
            lbRealTime.Text = DateTime.Now.ToLongTimeString();
            realTimeClock.Start();
        }

        private void LoadAttendanceWithDateRange(DateTime fromDate, DateTime toDate)
        {
            string query = "SELECT CAST(Date AS DATE) AS Day, CONVERT(VARCHAR, CAST(Date AS TIME), 108) AS Time, Review " +
                           "FROM Attendance WHERE Id = @id AND CAST(Date AS DATE) BETWEEN @fromDate AND @toDate ORDER BY Date DESC";

            var dt = dbHelper.ExecuteQuery(query,
                new SqlParameter("@id", this.id),
                new SqlParameter("@fromDate", fromDate.Date),
                new SqlParameter("@toDate", toDate.Date));

            // Cập nhật dữ liệu vào DataGridView
            dgv.DataSource = dt;

            dgv.Columns["Day"].HeaderText = "Ngày";
            dgv.Columns["Time"].HeaderText = "Giờ (Thời gian)";
            dgv.Columns["Review"].HeaderText = "Trạng thái";

            dgv.Columns["Day"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv.Columns["Time"].DefaultCellStyle.Format = ""; // Định dạng giờ nếu cần
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (btnSearch.Text == "Tìm kiếm")
            {
                btnSearch.Text = "Huỷ tìm";  
                btnAttend.Enabled = false;   
                pnFromTo.Enabled = true;     
            }
            else
            {
                btnSearch.Text = "Tìm kiếm";  
                btnAttend.Enabled = true;     
                pnFromTo.Enabled = false;    
                LoadAttendance();
            }
        }

        private void dtpValueChanged(object sender, EventArgs e)
        {
            if (dtpTo.Value > DateTime.Now.AddDays(1))
            {
                dtpTo.Value = DateTime.Now.AddDays(1);
            }

            if (dtpFrom.Value > dtpTo.Value)
            {
                dtpFrom.Value = dtpTo.Value;
            }

            LoadAttendanceWithDateRange(dtpFrom.Value, dtpTo.Value);
        }
    }
}