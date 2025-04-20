using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace timber_shop_manager.objects
{
    internal class Customer
    {
        private static DatabaseHelper dbHelper = new();
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public List<string> Cart { get; set; }

        public Customer (string phoneNumber, string name, string address) 
        {
            this.PhoneNumber = phoneNumber;
            this.Name = name;
            this.Address = address;
            this.Cart = new List<string>();
        }

        public static Customer GetCustomer(string phoneNumber)
        {
            string query = "SELECT PhoneNumber, Name, Address FROM Customer WHERE PhoneNumber = @PhoneNumber AND IsDeleted = 0";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PhoneNumber", phoneNumber)
            };

            DataTable dt = dbHelper.ExecuteQuery(query, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                string name = row["Name"].ToString();
                string address = row["Address"].ToString();

                return new Customer(phoneNumber, name, address); 
            }

            return null;
        }

        public static void add(Customer customer)
        {
            bool isUpdated = false;
            // Kiểm tra nếu khách hàng đã tồn tại trong cơ sở dữ liệu
            string query = "SELECT COUNT(PhoneNumber) FROM Customer WHERE PhoneNumber = @PhoneNumber";
            int count = Convert.ToInt32(dbHelper.ExecuteScalar(query, new SqlParameter("@PhoneNumber", customer.PhoneNumber)));

            if (count != 0)
            {
                // Nếu khách hàng đã tồn tại, cập nhật thông tin khách hàng
                query = "UPDATE Customer SET Name = @Name, Address = @Address WHERE PhoneNumber = @PhoneNumber";
                isUpdated = true;
            }
            else
            {
                // Nếu khách hàng chưa tồn tại, thêm mới vào cơ sở dữ liệu
                query = "INSERT INTO Customer (PhoneNumber, Name, Address) VALUES (@PhoneNumber, @Name, @Address)";
            }

            // Thực hiện câu lệnh SQL
            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@PhoneNumber", customer.PhoneNumber),
                new SqlParameter("@Name", customer.Name),
                new SqlParameter("@Address", customer.Address));

            if (isUpdated)
            {
                MessageBox.Show("Thông tin khách hàng đã được cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Khách hàng đã được thêm vào thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
