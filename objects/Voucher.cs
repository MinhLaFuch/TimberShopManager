using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace timber_shop_manager.objects
{
    public class Voucher
    {
        private static DatabaseHelper dbHelper = new();

        public static readonly string PREFIX = "V";
        public static readonly int CODE_LENGTH = 4;

        private string id, name, discription;  
        private DateTime startDate, endDate;
        private float percentant;
        private int price;

        public Voucher(string id, string name, DateTime startDate, DateTime endDate, string discription, string percentant, string price)
        {
            this.id = id.Trim();
            this.name = name.Trim();
            this.startDate = startDate;
            this.endDate = endDate;
            this.discription = discription.Trim(); 
            this.percentant = float.Parse(percentant.Trim());
            this.price = int.Parse(price.Trim());
        }

        public static void add(Voucher v)
        {
            string query = "SELECT COUNT(Id) FROM Voucher WHERE Id = @id";
            int count = Convert.ToInt32(dbHelper.ExecuteScalar(query, new SqlParameter("@id", v.id)));

            if (count != 0)
            {
                MessageBox.Show("Voucher với ID " + v.id + " đã tồn tại. Không thể thêm mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                query = "INSERT INTO Voucher (Id, Name, StartDate, EndDate, Discription, Percentant, Price) VALUES " +  
                        "(@id, @name, @startDate, @endDate, @discription, @percentant, @price)"; 

                dbHelper.ExecuteNonQuery(query,
                    new SqlParameter("@id", v.id),
                    new SqlParameter("@name", v.name),
                    new SqlParameter("@startDate", v.startDate),
                    new SqlParameter("@endDate", v.endDate),
                    new SqlParameter("@discription", v.discription), 
                    new SqlParameter("@percentant", v.percentant),
                    new SqlParameter("@price", v.price));

                MessageBox.Show("Voucher với ID " + v.id + " đã được thêm thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static Voucher getVoucherById(string voucherId)
        {
            string query = "SELECT * FROM Voucher WHERE Id = @id";
            SqlDataReader reader = dbHelper.ExecuteReader(query, new SqlParameter("@id", voucherId));

            if (reader.Read())
            {
                return new Voucher(
                    reader["Id"].ToString(),
                    reader["Name"].ToString(),
                    Convert.ToDateTime(reader["StartDate"]),
                    Convert.ToDateTime(reader["EndDate"]),
                    reader["Discription"].ToString(),  
                    reader["Percentant"].ToString(),
                    reader["Price"].ToString()
                );
            }
            else
            {
                return null;
            }
        }
    }
}
