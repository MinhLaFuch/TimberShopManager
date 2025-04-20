using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace timber_shop_manager.objects
{
    public class Attendance
    {
        public static readonly TimeSpan 
            WORKING_HOURS = new TimeSpan(8, 0, 0), 
            FINISHING_TIME = new TimeSpan(17, 0, 0);

        private static readonly int MINUTES_BETWEEN_CLOCKINS = 120;

        public static class STATUS
        {
            public static readonly string
                CHECK_IN_ON_TIME = "Đi đúng giờ",
                CHECK_IN_LATE = "Đi muộn",
                CHECK_IN_EARLY = "Đến sớm",
                CHECK_OUT_ON_TIME = "Về đúng giờ",
                CHECK_OUT_EARLY = "Về sớm",
                CHECK_IN = "Check-in",
                CHECK_OUT = "Check-out";
        }

        private static DatabaseHelper dbHelper = new();

        public string id;
        public DateTime date;

        public Attendance(string id, DateTime date)
        {
            this.id = id.Trim();
            this.date = date;
        }

        public void add()
        {
            string query = "SELECT COUNT(*) FROM Attendance WHERE Id = @id AND CAST(Date AS DATE) = @date";
            int count = Convert.ToInt32(dbHelper.ExecuteScalar(query,
                new SqlParameter("@id", this.id),
                new SqlParameter("@date", this.date.Date)));

            // Kiểm tra nếu đã đủ 2 lần chấm công trong ngày
            if (count >= 2)
            {
                MessageBox.Show("Đã đủ 2 lần chấm công trong ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Không ghi thêm vào database nếu đã đủ 2 lần
            }

            query = "SELECT Date FROM Attendance WHERE Id = @id AND CAST(Date AS DATE) = @date ORDER BY Date ASC";
            var dt = dbHelper.ExecuteQuery(query,
                new SqlParameter("@id", this.id),
                new SqlParameter("@date", this.date.Date));

            bool canInsert = true;

            foreach (DataRow row in dt.Rows)
            {
                DateTime existingClockIn = Convert.ToDateTime(row["Date"]);

                // Kiểm tra thời gian giữa lần chấm công hiện tại và lần trước đó
                if ((this.date - existingClockIn).TotalMinutes < MINUTES_BETWEEN_CLOCKINS)
                {
                    MessageBox.Show($"Không thể chấm công.\nChưa đủ {MINUTES_BETWEEN_CLOCKINS} phút từ lần chấm công trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    canInsert = false;
                    break;
                }
            }

            // Nếu không gặp lỗi, tiếp tục chấm công
            if (canInsert)
            {
                // Kiểm tra xem có phải là Check-in hay Check-out
                if (dt.Rows.Count == 0)
                {
                    InsertAttendance(STATUS.CHECK_IN); // Nếu chưa có lần chấm công, thì là Check-in
                }
                else
                {
                    InsertAttendance(STATUS.CHECK_OUT); // Nếu đã có lần chấm công, thì là Check-out
                }
            }
        }

        private void InsertAttendance(string check)
        {
            string msg = GetReviewStatus(this.date, check);
            string review = $"{check}: {msg}";

            string query = "INSERT INTO Attendance (Id, Date, Review) VALUES (@id, @date, @review)";
            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@id", this.id),
                new SqlParameter("@date", this.date),
                new SqlParameter("@review", review ?? (object)DBNull.Value));

            MessageBox.Show($"Chấm công thành công!\nTrạng thái: {msg}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private string GetReviewStatus(DateTime clockInTime, string actionType)
        {
            if (actionType == STATUS.CHECK_IN)
            {
                if (clockInTime.TimeOfDay <= WORKING_HOURS)
                {
                    return STATUS.CHECK_IN_ON_TIME; // Đến đúng giờ
                }
                else if (clockInTime.TimeOfDay > WORKING_HOURS && clockInTime.TimeOfDay < FINISHING_TIME)
                {
                    return STATUS.CHECK_IN_LATE; // Đi muộn
                }
                else if (clockInTime.TimeOfDay < WORKING_HOURS)
                {
                    return STATUS.CHECK_IN_EARLY; // Đến sớm
                }
            }
            // Nếu là Check-out
            else if (actionType == STATUS.CHECK_OUT)
            {
                if (clockInTime.TimeOfDay < FINISHING_TIME)
                {
                    return STATUS.CHECK_OUT_EARLY; // Về sớm
                }
                else
                {
                    return STATUS.CHECK_OUT_ON_TIME; // Về đúng giờ
                }
            }

            return STATUS.CHECK_IN_ON_TIME; // Mặc định nếu không thỏa các điều kiện trên
        }
    }
}
