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
    internal class Product
    {
        public static readonly int SOLD_OUT = 0;
        public static readonly string PREFIX = "P";
        public static readonly int CODE_LENGTH = 5;

        private static DatabaseHelper dbHelper = new DatabaseHelper();

        private string id, categoryId, name, unit, description;
        private double price;
        private int warranty, quantity;

        public Product(string id, string categoryId, string name, string unit, double price, int warranty, string description, int quantity)
        {
            this.id = id;
            this.categoryId = categoryId;
            this.name = name;
            this.unit = unit;
            this.price = price;
            this.warranty = warranty;
            this.description = description;
            this.quantity = quantity;
        }

        public override string? ToString()
        {
            return $"{id.ToString().Trim().ToLower()} - {name} - {quantity} {unit}";
        }

        public static void add(Product product) 
        {
            string queryInsert = "INSERT INTO Product (ProductID, CatagoryID, Name, CalculationUnit, PriceQuotation, CustomerWarranty, Description, Quantity) " +
                        "VALUES (@ID, @CatagoryID, @Name, @CalUnit, @PriceQuo, @Warranty, @Description, @Quantity)";
            string queryUpdate = "UPDATE Product " +
                "SET CatagoryID = @CatagoryID, " +
                    "Name = @Name, " +
                    "CalculationUnit = @CalUnit, " +
                    "PriceQuotation = @PriceQuo, " +
                    "CustomerWarranty = @Warranty, " +
                    "Description = @Description, " +
                    "Quantity = @Quantity " +
                "WHERE ProductID = @ID";

            string query = "SELECT COUNT(*) FROM Product WHERE ProductId = @id";
            bool isExists = Convert.ToInt32(dbHelper.ExecuteScalar(query, new SqlParameter("@id", product.id))) != 0;

            if (!isExists) 
            {
                dbHelper.ExecuteNonQuery(queryInsert,
                    new SqlParameter("@ID", product.id),
                    new SqlParameter("@CatagoryID", product.categoryId),
                    new SqlParameter("@Name", product.name),
                    new SqlParameter("@CalUnit", product.unit),
                    new SqlParameter("@PriceQuo", product.price),
                    new SqlParameter("@Warranty", product.warranty),
                    new SqlParameter("@Description", product.description),
                    new SqlParameter("@Quantity", product.quantity));
            } 
            else
            {
                dbHelper.ExecuteNonQuery(queryUpdate,
                    new SqlParameter("@ID", product.id),
                    new SqlParameter("@CatagoryID", product.categoryId),
                    new SqlParameter("@Name", product.name),
                    new SqlParameter("@CalUnit", product.unit),
                    new SqlParameter("@PriceQuo", product.price),
                    new SqlParameter("@Warranty", product.warranty),
                    new SqlParameter("@Description", product.description),
                    new SqlParameter("@Quantity", product.quantity));
            }
        }

        public static void delete(Product product)
        {
            string query = "DELETE FROM Product WHERE ProductId = @id";

            dbHelper.ExecuteNonQuery(query, new SqlParameter("@id", product.id));
        }
    }
}
