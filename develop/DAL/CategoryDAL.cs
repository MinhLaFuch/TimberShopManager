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
    public class CategoryDAL
    {
        private DatabaseHelper dbHelper = new();

        public DataTable GetAllCategories()
        {
            string query = "SELECT Id AS 'Mã danh mục', Name AS 'Tên', Description AS 'Mô tả' FROM Category WHERE IsShow = 1 ORDER BY Id";
            return dbHelper.ExecuteQuery(query);
        }

        public void InsertOrUpdate(CategoryDTO c)
        {
            string queryCheck = "SELECT COUNT(Id) FROM Category WHERE Id = @id";
            int count = Convert.ToInt32(dbHelper.ExecuteScalar(queryCheck, new SqlParameter("@id", c.Id)));

            string query;
            if (count > 0)
            {
                query = "UPDATE Category SET Name = @name, Description = @desc WHERE Id = @id";
            }
            else
            {
                query = "INSERT INTO Category (Id, Name, Description) VALUES (@id, @name, @desc)";
            }

            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@id", c.Id),
                new SqlParameter("@name", c.Name),
                new SqlParameter("@desc", c.Description));
        }

        public void Delete(CategoryDTO c)
        {
            string query = "UPDATE Category SET IsShow = 0 WHERE Id = @id";
            dbHelper.ExecuteNonQuery(query, new SqlParameter("@id", c.Id));
        }

        public void Insert(CategoryDTO dto)
        {
            string query = "INSERT INTO Category (Id, Name, Description, IsShow) VALUES (@Id, @Name, @Description, 1)";

            dbHelper.ExecuteNonQuery(query, 
                new SqlParameter("@Id", dto.Id),
                new SqlParameter("@Name", dto.Name),
                new SqlParameter("@Description", dto.Description ?? ""));
        }

        public string GetLastCategoryId()
        {
            string query = "SELECT MAX(Id) FROM Category";
            var result = dbHelper.ExecuteScalar(query);
            return result?.ToString();
        }

    }
}
