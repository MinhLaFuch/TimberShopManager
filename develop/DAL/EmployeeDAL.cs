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
    public class EmployeeDAL
    {
        private readonly DatabaseHelper dbHelper = new DatabaseHelper();

        public DataTable GetEmployeeData()
        {
            string query = @"
                SELECT 
                    Id AS 'Mã', 
                    Name AS 'Tên', 
                    IdentificationNumber AS 'Số CCCD', 
                    PhoneNumber AS 'Số điện thoại', 
                    Address AS 'Nơi ở',
                    Role AS 'Chức danh', 
                    CONVERT(varchar, Birthday, 103) AS 'Ngày sinh', 
                    Salary AS 'Lương'
                FROM Employee
                WHERE IsDeleted = 0
                ORDER BY Id";

            return dbHelper.ExecuteQuery(query);
        }

        public List<string> GetRoles()
        {
            string query = "SELECT DISTINCT Role FROM Employee ORDER BY Role";
            return dbHelper.GetDataForComboBox(query, "Role");
        }

        public void SaveEmployee(EmployeeDTO emp)
        {
            string queryCheck = "SELECT COUNT(Id) FROM Employee WHERE Id = @id";
            int count = Convert.ToInt32(dbHelper.ExecuteScalar(queryCheck, new SqlParameter("@id", emp.Id)));

            string query;
            if (count > 0)
            {
                query = @"UPDATE Employee SET 
                    Name = @name, IdentificationNumber = @iden, Address = @address, Birthday = @birth,
                    Salary = @salary, PhoneNumber = @phone, Role = @role
                    WHERE Id = @id";
            }
            else
            {
                query = @"INSERT INTO Employee (Id, Name, IdentificationNumber, Address, Birthday, Salary, PhoneNumber, Role)
                    VALUES (@id, @name, @iden, @address, @birth, @salary, @phone, @role)";
            }

            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@id", emp.Id),
                new SqlParameter("@name", emp.Name),
                new SqlParameter("@iden", emp.IdentificationNumber),
                new SqlParameter("@address", emp.Address),
                new SqlParameter("@birth", emp.Birthday),
                new SqlParameter("@salary", emp.Salary),
                new SqlParameter("@phone", emp.PhoneNumber),
                new SqlParameter("@role", emp.Role));
        }

        public void DeleteEmployee(string id)
        {
            string query = "UPDATE Employee SET IsDeleted = 1 WHERE Id = @id";
            dbHelper.ExecuteNonQuery(query, new SqlParameter("@id", id));
        }

        public string GetLastEmployeeId()
        {
            string query = "SELECT MAX(Id) FROM Employee";
            var result = dbHelper.ExecuteScalar(query);
            return result == null || result == DBNull.Value ? null : result.ToString();
        }

        public EmployeeDTO GetEmployeeById(string id)
        {
            string query = "SELECT * FROM Employee WHERE Id = @id AND IsDeleted = 0";
            var table = dbHelper.ExecuteQuery(query, new SqlParameter("@id", id));

            if (table.Rows.Count == 0) return null;

            var row = table.Rows[0];
            return new EmployeeDTO
            {
                Id = row["Id"].ToString(),
                Name = row["Name"].ToString(),
                IdentificationNumber = row["IdentificationNumber"].ToString(),
                Address = row["Address"].ToString(),
                Birthday = Convert.ToDateTime(row["Birthday"]),
                Salary = Convert.ToDouble(row["Salary"]),
                PhoneNumber = row["PhoneNumber"].ToString(),
                Role = row["Role"].ToString()
            };
        }

    }
}
