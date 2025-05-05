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
    public class SupplierDAL
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();

        public DataTable GetAllSuppliers()
        {
            string sql = "SELECT * FROM Supplier WHERE IsDeleted = 0";
            return dbHelper.ExecuteQuery(sql);
        }

        public void AddOrUpdate(SupplierDTO supplier)
        {
            string checkSql = "SELECT COUNT(*) FROM Supplier WHERE Id = @id";
            bool exists = Convert.ToInt32(dbHelper.ExecuteScalar(checkSql, new SqlParameter("@id", supplier.Id))) > 0;

            string sql = exists
                ? @"UPDATE Supplier SET Name = @Name, ContactNumber = @Contact, Address = @Address, Email = @Email, Website = @Website WHERE Id = @Id"
                : @"INSERT INTO Supplier (Id, Name, ContactNumber, Address, Email, Website) 
                    VALUES (@Id, @Name, @Contact, @Address, @Email, @Website)";

            dbHelper.ExecuteNonQuery(sql,
                new SqlParameter("@Id", supplier.Id),
                new SqlParameter("@Name", supplier.Name),
                new SqlParameter("@Contact", supplier.PhoneNumber),
                new SqlParameter("@Address", supplier.Address),
                new SqlParameter("@Email", supplier.Email),
                new SqlParameter("@Website", supplier.Website));
        }

        public void Delete(SupplierDTO supplier)
        {
            string sql = "UPDATE Supplier SET IsDeleted = 1 WHERE Id = @id";
            dbHelper.ExecuteNonQuery(sql, new SqlParameter("@id", supplier.Id));
        }

        public SupplierDTO GetByPhone(string phoneNumber)
        {
            string query = "SELECT * FROM Supplier WHERE ContactNumber = @ContactNumber AND IsDeleted = 0";
            DataTable dt = dbHelper.ExecuteQuery(query, new SqlParameter("@ContactNumber", phoneNumber));

            if (dt.Rows.Count == 0)
                return null;

            DataRow row = dt.Rows[0];
            return new SupplierDTO
            {
                Id = row["Id"].ToString(),
                Name = row["Name"].ToString(),
                Address = row["Address"].ToString(),
                PhoneNumber = row["ContactNumber"].ToString(),
                Email = row["Email"].ToString(),
                Website = row["Website"].ToString()
            };
        }

        public SupplierDTO GetById(string id)
        {
            string query = "SELECT * FROM Supplier WHERE Id = @Id AND IsDeleted = 0";

            DataTable dt = dbHelper.ExecuteQuery(query, new SqlParameter("@Id", id));

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new SupplierDTO
                {
                    Id = row["Id"].ToString(),
                    Name = row["Name"].ToString(),
                    Address = row["Address"].ToString(),
                    PhoneNumber = row["ContactNumber"].ToString(),
                    Email = row["Email"].ToString(),
                    Website = row["Website"].ToString()
                };
            }

            return null;
        }

        public string GetLastSupplierId()
        {
            string query = "SELECT MAX(Id) FROM Supplier WHERE IsDeleted = 0";
            object result = dbHelper.ExecuteScalar(query);
            return result == DBNull.Value ? null : result.ToString();
        }
    }
}
