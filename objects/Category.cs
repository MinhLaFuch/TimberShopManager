using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace timber_shop_manager.objects
{
    internal class Category
    {
        public static readonly string PREFIX = "P";
        public static readonly int CODE_LENGTH = 6;

        private static DatabaseHelper dbHelper = new DatabaseHelper();
        public static string getName(string id)
        {
            if (id != null)
            {
                string query = "SELECT Name FROM Catagory WHERE CatagoryID = @id";
                string categoryName = Convert.ToString(dbHelper.ExecuteScalar(query, new SqlParameter("@id", id)));
                return (categoryName != null) ? categoryName : string.Empty;
            }
            return string.Empty;
        }

        public static string getId(string name)
        {
            string query = "SELECT CatagoryId FROM Catagory WHERE Name = @name";
            return Convert.ToString(dbHelper.ExecuteScalar(query, new SqlParameter("@name", name)));
        }
    }
}
