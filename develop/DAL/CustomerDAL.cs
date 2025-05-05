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

    namespace TimberShop.DAL
    {
        public class CustomerDAL
        {
            private readonly DatabaseHelper db = new();

            public CustomerDTO GetByPhone(string phoneNumber)
            {
                var query = "SELECT * FROM Customer WHERE PhoneNumber = @PhoneNumber AND IsDeleted = 0";
                var parameters = new SqlParameter[] {
                new("@PhoneNumber", phoneNumber)
            };

                var dt = db.ExecuteQuery(query, parameters);
                if (dt.Rows.Count == 0) return null;

                var row = dt.Rows[0];
                return new CustomerDTO
                {
                    PhoneNumber = row["PhoneNumber"].ToString(),
                    Name = row["Name"].ToString(),
                    Address = row["Address"].ToString(),
                    IsDeleted = Convert.ToBoolean(row["IsDeleted"])
                };
            }

            public void Insert(CustomerDTO customer)
            {
                var query = @"INSERT INTO Customer (PhoneNumber, Name, Address, IsDeleted)
                          VALUES (@PhoneNumber, @Name, @Address, 0)";
                db.ExecuteNonQuery(query,
                    new SqlParameter("@PhoneNumber", customer.PhoneNumber),
                    new SqlParameter("@Name", customer.Name),
                    new SqlParameter("@Address", customer.Address));
            }

            public void Update(CustomerDTO customer)
            {
                var query = @"UPDATE Customer 
                          SET Name = @Name, Address = @Address 
                          WHERE PhoneNumber = @PhoneNumber";
                db.ExecuteNonQuery(query,
                    new SqlParameter("@PhoneNumber", customer.PhoneNumber),
                    new SqlParameter("@Name", customer.Name),
                    new SqlParameter("@Address", customer.Address));
            }

            public void Delete(string phoneNumber)
            {
                var query = "UPDATE Customer SET IsDeleted = 1 WHERE PhoneNumber = @PhoneNumber";
                db.ExecuteNonQuery(query, new SqlParameter("@PhoneNumber", phoneNumber));
            }

            public bool Exists(string phoneNumber)
            {
                var query = "SELECT COUNT(*) FROM Customer WHERE PhoneNumber = @PhoneNumber AND IsDeleted = 0";
                var result = db.ExecuteScalar(query, new SqlParameter("@PhoneNumber", phoneNumber));
                return Convert.ToInt32(result) > 0;
            }

            public DataTable GetAll()
            {
                return db.ExecuteQuery("SELECT * FROM Customer WHERE IsDeleted = 0");
            }

            public List<string> GetAllPhoneNumbers()
            {
                string query = "SELECT PhoneNumber FROM Customer";
                return db.GetDataForComboBox(query, "PhoneNumber");
            }
        }
    }

}
