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
using timber_shop_manager.BUS;
using timber_shop_manager.DTO;
using timber_shop_manager.objects;

namespace timber_shop_manager
{
    public partial class frmAttendance : Form
    {
        #region Properties
        private EmployeeDTO emp;
        private AttendanceBUS bus = new();

        private string id;

        public frmAttendance()
        {
            InitializeComponent();
            realTimeClock.Start();
        }

        public frmAttendance(EmployeeDTO emp) : this()
        {
            this.emp = emp;
            id = emp.Id;
        }
        #endregion
        #region Support methods
        private void LoadAttendanceWithDateRange(DateTime from, DateTime to)
        {
            dgv.DataSource = bus.GetAttendanceByDateRange(id, from, to);
        }
        private void LoadAttendance()
        {
            dgv.DataSource = bus.GetAttendanceByEmployee(id);
        }
        #endregion
        #region Load event
        private void frmAttendance_Load(object sender, EventArgs e)
        {
            lbEmployeeId.Text = id;
            pnFromTo.Enabled = false;

            DateTime now = DateTime.Now;
            DateTime startDate = now.AddDays(-1).Date; // mặc định dtpFrom là hôm qua
            DateTime endDate = now;                    // dtpTo là thời điểm hiện tại

            // Ghi đè lại các giá trị bị set cứng trong Designer
            dtpFrom.Value = startDate;
            dtpTo.Value = endDate;

            // Đặt giới hạn max cho cả hai để giữ đúng logic
            dtpFrom.MaxDate = endDate.AddSeconds(-1); // luôn nhỏ hơn dtpTo
            dtpTo.MaxDate = now;                      // luôn nhỏ hơn hiện tại

            LoadAttendance();
        }
        #endregion
        #region Button click event
        private void btnAttend_Click(object sender, EventArgs e)
        {
            var attendance = new AttendanceDTO(id, DateTime.Now);
            bus.AddAttendance(attendance);
            LoadAttendance();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnFromTo.Enabled = !pnFromTo.Enabled;
            btnAttend.Enabled = !btnAttend.Enabled;
            btnSearch.Text = pnFromTo.Enabled ? "Huỷ tìm" : "Tìm kiếm";
            if (!pnFromTo.Enabled) LoadAttendance();
        }
        #endregion
        #region Tick event
        private void realTimeClock_Tick(object sender, EventArgs e)
        {
            lbRealTime.Text = DateTime.Now.ToLongTimeString();
            realTimeClock.Start();
        }
        #endregion
        #region Value changed event
        private void dtpValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            // Ensure dtpTo is not in the future
            if (dtpTo.Value >= now)
            {
                dtpTo.Value = now;
            }

            // Ensure dtpFrom < dtpTo
            if (dtpFrom.Value >= dtpTo.Value)
            {
                dtpFrom.Value = dtpTo.Value.AddDays(-1);
            }

            LoadAttendanceWithDateRange(dtpFrom.Value, dtpTo.Value);
        }
        #endregion
    }
}