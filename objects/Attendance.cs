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
                CHECK_OUT_EARLY = "Về sớm";
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

            if (count == 0)
            {
                InsertAttendance();
            }
            else
            {
                query = "SELECT Date FROM Attendance WHERE Id = @id AND CAST(Date AS DATE) = @date ORDER BY Date ASC";

                var dt = dbHelper.ExecuteQuery(query,
                    new SqlParameter("@id", this.id),
                    new SqlParameter("@date", this.date.Date));

                DateTime firstClockIn = DateTime.MinValue;
                bool canInsert = true;

                foreach (DataRow row in dt.Rows)
                {
                    DateTime existingClockIn = Convert.ToDateTime(row["Date"]);

                    if (firstClockIn == DateTime.MinValue)
                    {
                        firstClockIn = existingClockIn;
                    }
                    else if ((this.date - firstClockIn).TotalMinutes < MINUTES_BETWEEN_CLOCKINS)
                    {
                        canInsert = false;
                        break;
                    }
                }

                if (canInsert)
                {
                    string review = GetReviewStatus(this.date);
                    InsertAttendance();
                    MessageBox.Show($"Chấm công thành công!\nTrạng thái: {review}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không thể chấm công. Đã đủ 2 lần trong ngày hoặc chưa đủ 2 tiếng từ lần chấm công trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void InsertAttendance()
        {
            string review = GetReviewStatus(this.date);

            string query = "INSERT INTO Attendance (Id, Date, Review) VALUES (@id, @date, @review)";
            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@id", this.id),
                new SqlParameter("@date", this.date),
                new SqlParameter("@review", review ?? (object)DBNull.Value));
        }

        private string GetReviewStatus(DateTime clockInTime)
        {
            if (clockInTime.TimeOfDay <= WORKING_HOURS)
            {
                return STATUS.CHECK_IN_ON_TIME; 
            }
            else if (clockInTime.TimeOfDay > WORKING_HOURS && clockInTime.TimeOfDay < FINISHING_TIME)
            {
                return STATUS.CHECK_IN_LATE; 
            }
            else if (clockInTime.TimeOfDay < WORKING_HOURS)
            {
                return STATUS.CHECK_IN_EARLY; 
            }
            return STATUS.CHECK_IN_ON_TIME; 
        }
    }
}
