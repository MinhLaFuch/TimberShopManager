using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using timber_shop_manager.DTO;

namespace timber_shop_manager.DAL
{
    public class VoucherDAL
    {
        private readonly DatabaseHelper dbHelper = new();

        public bool Exists(string id)
        {
            string query = "SELECT COUNT(*) FROM Voucher WHERE Id = @id";
            int count = Convert.ToInt32(dbHelper.ExecuteScalar(query, new SqlParameter("@id", id)));
            return count > 0;
        }

        public void Insert(VoucherDTO voucher)
        {
            string query = "INSERT INTO Voucher (Id, Name, StartDate, EndDate, Discription, Percentant, Price) " +
                           "VALUES (@id, @name, @startDate, @endDate, @description, @percentant, @price)";

            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@id", voucher.Id),
                new SqlParameter("@name", voucher.Name),
                new SqlParameter("@startDate", voucher.StartDate),
                new SqlParameter("@endDate", voucher.EndDate),
                new SqlParameter("@description", voucher.Description),
                new SqlParameter("@percentant", voucher.Percentant),
                new SqlParameter("@price", voucher.Price));
        }

        public DataTable GetAll()
        {
            string query = "SELECT Id AS Mã, Name AS Tên, StartDate AS [Ngày Bắt Đầu], EndDate AS [Ngày Kết Thúc], Discription AS [Mô Tả], Percentant AS [Phần Trăm], Price AS Giá FROM Voucher";
            return dbHelper.ExecuteQuery(query);
        }

        public DataTable GetAllVoucherCodes()
        {
            string query = "SELECT Id FROM Voucher WHERE EndDate >= GETDATE()";
            return dbHelper.ExecuteQuery(query);
        }
        public VoucherDTO GetVoucherById(string id)
        {
            string query = @"SELECT Percentant, Price, StartDate, EndDate FROM Voucher WHERE Id = @Id";
            var param = new SqlParameter("@Id", id);

            DataTable dt = dbHelper.ExecuteQuery(query, param);
            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            return new VoucherDTO
            {
                Id = id,
                Percentant = row["Percentant"] != DBNull.Value ? Convert.ToDecimal(row["Percentant"]) : 0m,
                Price = row["Price"] != DBNull.Value ? Convert.ToInt32(row["Price"]) : 0,
                StartDate = Convert.ToDateTime(row["StartDate"]),
                EndDate = Convert.ToDateTime(row["EndDate"])
            };
        }

    }
}
