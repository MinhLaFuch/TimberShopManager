using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace timber_shop_manager.objects
{
    public class Category
    {
        public static readonly string PREFIX = "CAT";
        public static readonly int CODE_LENGTH = 5;

        private static readonly DatabaseHelper dbHelper = new();
        private string id, name, description;

        public Category(string id, string name, string description)
        {
            this.id = id.Trim();
            this.name = name.Trim();
            this.description = description.Trim();
        }

        public static string getName(string id)
        {
            if (!string.IsNullOrWhiteSpace(id))
            {
                string query = "SELECT Name FROM Category WHERE Id = @id";
                string categoryName = Convert.ToString(dbHelper.ExecuteScalar(query, new SqlParameter("@id", id)));
                return categoryName ?? string.Empty;
            }
            return string.Empty;
        }

        public static string getId(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                string query = "SELECT Id FROM Category WHERE Name = @name";
                return Convert.ToString(dbHelper.ExecuteScalar(query, new SqlParameter("@name", name)));
            }
            return string.Empty;
        }

        public static void add(Category c)
        {
            string query = "SELECT COUNT(Id) FROM Category WHERE Id = @id";
            int count = Convert.ToInt32(dbHelper.ExecuteScalar(query, new SqlParameter("@id", c.id)));

            if (count > 0)
            {
                query = "UPDATE Category SET Name = @name, Description = @desc WHERE Id = @id";
            }
            else
            {
                query = "INSERT INTO Category (Id, Name, Description) VALUES (@id, @name, @desc)";
            }

            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@id", c.id),
                new SqlParameter("@name", c.name),
                new SqlParameter("@desc", c.description));
        }

        public static void delete(Category c)
        {
            string query = "UPDATE Category SET IsShow = 0 WHERE Id = @id";
            dbHelper.ExecuteNonQuery(query, new SqlParameter("@id", c.id));
        }
    }
}
