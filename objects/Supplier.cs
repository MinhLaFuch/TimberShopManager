using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using Azure.Core;

namespace timber_shop_manager.objects
{
    public class Supplier
    {
        public static readonly string PREFIX = "SI";
        public static readonly int CODE_LENGTH = 6;

        private string id, name, address, contact, email, website;
        private static DatabaseHelper dbHelper = new DatabaseHelper();

        public string Name { get; }
        public Supplier(string id, string name, string address, string contact, string email, string website)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.contact = contact;
            this.email = email;
            this.website = website;
        }
        public static void add(Supplier supplier) 
        {
            string queryInsert = "INSERT INTO Supplier (SupplierId, Name, ContactNumber, Address, Email, Website) " +
                        "VALUES (@ID, @Name, @PhoneNumber, @Address, @Email, @Website)";
            string queryUpdate = "UPDATE Supplier " +
                "SET Name = @Name, " +
                    "ContactNumber = @PhoneNumber, " +
                    "Address = @Address, " +
                    "Email = @Email, " +
                    "Website = @Website " +
                "WHERE SupplierID = @ID";

            string query = "SELECT COUNT(*) FROM Supplier WHERE SupplierId = @id";
            bool isExists = Convert.ToInt32(dbHelper.ExecuteScalar(query, new SqlParameter("@id", supplier.id))) != 0;

            if (!isExists)
            {                
                dbHelper.ExecuteNonQuery(queryInsert,
                    new SqlParameter("@ID", supplier.id),
                    new SqlParameter("@Name", supplier.name),
                    new SqlParameter("@PhoneNumber", supplier.contact),
                    new SqlParameter("@Address", supplier.address),
                    new SqlParameter("@Email", supplier.email),
                    new SqlParameter("@Website", supplier.website));
            }
            else
            {
                dbHelper.ExecuteNonQuery(queryUpdate,
                    new SqlParameter("@ID", supplier.id),
                    new SqlParameter("@Name", supplier.name),
                    new SqlParameter("@PhoneNumber", supplier.contact),
                    new SqlParameter("@Address", supplier.address),
                    new SqlParameter("@Email", supplier.email),
                    new SqlParameter("@Website", supplier.website));
            }
        }

        public static void delete(Supplier supplier) 
        {
            string queryDel = "DELETE FROM Supplier WHERE SupplierId = @id";

            dbHelper.ExecuteNonQuery(queryDel, new SqlParameter("@id", supplier.id));
        }
    }
}
