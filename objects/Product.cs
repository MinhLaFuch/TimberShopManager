using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;

namespace timber_shop_manager.objects
{
    public class Product
    {
        public static readonly string PREFIX = "P";
        public static readonly int CODE_LENGTH = 4;

        private static DatabaseHelper dbHelper = new DatabaseHelper();

        protected string id, catId, name, calculationUnit, description;
        protected double priceQuotation;
        protected int quantity, customerWarranty;

        public Product(string id, string catId, string name, string calculationUnit, string priceQuotation,
                       string quantity, string customerWarranty, string description)
        {
            this.id = id.Trim();
            this.catId = catId.Trim();
            this.name = InputValidator.CapitalizeName(name.Trim());
            this.calculationUnit = calculationUnit.Trim();
            this.priceQuotation = Convert.ToDouble(priceQuotation.Trim());
            this.quantity = Convert.ToInt32(quantity.Trim());
            this.customerWarranty = Convert.ToInt32(customerWarranty.Trim());
            this.description = description.Trim();
        }

        public static void add(Product p)
        {
            string query = "SELECT COUNT(Id) FROM Product WHERE Id = @id";
            int count = Convert.ToInt32(dbHelper.ExecuteScalar(query, new SqlParameter("@id", p.id)));

            if (count != 0)
            {
                query = @"UPDATE Product SET 
                            CatId = @catId, Name = @name, CalculationUnit = @unit,
                            PriceQuotation = @price, Quantity = @quantity,
                            CustomerWarranty = @warranty, Description = @desc
                          WHERE Id = @id";
            }
            else
            {
                query = @"INSERT INTO Product (Id, CatId, Name, CalculationUnit, PriceQuotation, Quantity, CustomerWarranty, Description)
                          VALUES (@id, @catId, @name, @unit, @price, @quantity, @warranty, @desc)";
            }

            dbHelper.ExecuteNonQuery(query,
                new SqlParameter("@id", p.id),
                new SqlParameter("@catId", p.catId),
                new SqlParameter("@name", p.name),
                new SqlParameter("@unit", p.calculationUnit),
                new SqlParameter("@price", p.priceQuotation),
                new SqlParameter("@quantity", p.quantity),
                new SqlParameter("@warranty", p.customerWarranty),
                new SqlParameter("@desc", p.description));
        }

        public static void delete(Product p)
        {
            string query = "UPDATE Product SET IsDeleted = 1 WHERE Id = @id";
            dbHelper.ExecuteNonQuery(query, new SqlParameter("@id", p.id));
        }
    }
}
