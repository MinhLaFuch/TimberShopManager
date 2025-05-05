using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace timber_shop_manager.DAL
{
    public class AttendanceDAL
    {
        private DatabaseHelper dbHelper = new();

        public DataTable GetAttendanceByEmployee(string id)
        {
            string query = "SELECT CAST(Date AS DATE) AS Day, CONVERT(VARCHAR, CAST(Date AS TIME), 108) AS Time, Review FROM Attendance WHERE Id = @id ORDER BY Date DESC";
            return dbHelper.ExecuteQuery(query, new SqlParameter("@id", id));
        }

        public DataTable GetAttendanceByDateRange(string id, DateTime from, DateTime to)
        {
            string query = "SELECT CAST(Date AS DATE) AS Day, CONVERT(VARCHAR, CAST(Date AS TIME), 108) AS Time, Review FROM Attendance WHERE Id = @id AND CAST(Date AS DATE) BETWEEN @from AND @to ORDER BY Date DESC";
            return dbHelper.ExecuteQuery(query,
                new SqlParameter("@id", id),
                new SqlParameter("@from", from),
                new SqlParameter("@to", to));
        }

        public int GetCheckCountToday(string id, DateTime date)
        {
            string query = "SELECT COUNT(*) FROM Attendance WHERE Id = @id AND CAST(Date AS DATE) = @date";
            return Convert.ToInt32(dbHelper.ExecuteScalar(query, new SqlParameter("@id", id), new SqlParameter("@date", date.Date)));
        }

        public DataTable GetClockInsToday(string id, DateTime date)
        {
            string query = "SELECT Date FROM Attendance WHERE Id = @id AND CAST(Date AS DATE) = @date ORDER BY Date ASC";
            return dbHelper.ExecuteQuery(query, new SqlParameter("@id", id), new SqlParameter("@date", date.Date));
        }

        public void InsertAttendance(string id, DateTime date, string review)
        {
            string query = "INSERT INTO Attendance (Id, Date, Review) VALUES (@id, @date, @review)";
            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@id", id),
                new SqlParameter("@date", date),
                new SqlParameter("@review", review ?? (object)DBNull.Value));
        }
    }
}
