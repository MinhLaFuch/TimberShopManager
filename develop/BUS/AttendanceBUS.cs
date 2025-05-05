using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timber_shop_manager.DAL;
using timber_shop_manager.DTO;

namespace timber_shop_manager.BUS
{
    public class AttendanceBUS
    {
        private AttendanceDAL dal = new();

        private static readonly TimeSpan WORKING_HOURS = new TimeSpan(8, 0, 0);
        private static readonly TimeSpan FINISHING_TIME = new TimeSpan(17, 0, 0);
        private const int MINUTES_BETWEEN_CLOCKINS = 120;

        public DataTable GetAttendanceByEmployee(string id)
        {
            return dal.GetAttendanceByEmployee(id);
        }

        public DataTable GetAttendanceByDateRange(string id, DateTime from, DateTime to)
        {
            return dal.GetAttendanceByDateRange(id, from, to);
        }

        public void AddAttendance(AttendanceDTO attendance)
        {
            int count = dal.GetCheckCountToday(attendance.Id, attendance.Date);

            if (count >= 2)
            {
                MessageBox.Show("Đã đủ 2 lần chấm công trong ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable dt = dal.GetClockInsToday(attendance.Id, attendance.Date);

            foreach (DataRow row in dt.Rows)
            {
                DateTime previous = Convert.ToDateTime(row["Date"]);
                if ((attendance.Date - previous).TotalMinutes < MINUTES_BETWEEN_CLOCKINS)
                {
                    MessageBox.Show($"Không thể chấm công.\nChưa đủ {MINUTES_BETWEEN_CLOCKINS} phút từ lần trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            string checkType = dt.Rows.Count == 0 ? "Check-in" : "Check-out";
            string status = GetReviewStatus(attendance.Date, checkType);
            string review = $"{checkType}: {status}";

            dal.InsertAttendance(attendance.Id, attendance.Date, review);

            MessageBox.Show($"Chấm công thành công!\nTrạng thái: {status}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string GetReviewStatus(DateTime clockTime, string actionType)
        {
            TimeSpan time = clockTime.TimeOfDay;

            if (actionType == "Check-in")
            {
                if (time <= WORKING_HOURS)             
                    return "Đi đúng giờ";
                else                                    
                    return "Đi muộn";
            }
            else // Check-out
            {
                if (time < FINISHING_TIME)            
                    return "Về sớm";
                else
                    return "Về đúng giờ";
            }
        }

    }
}
