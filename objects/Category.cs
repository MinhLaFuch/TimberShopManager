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
        public static readonly string PREFIX = "C";
        public static readonly int CODE_LENGTH = 6;

        private static readonly DatabaseHelper dbHelper = new();

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
    }
}
