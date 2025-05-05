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
    public class ProductDAL
    {
        private readonly DatabaseHelper db = new();

        public DataTable GetAll()
        {
            string query = @"
            SELECT 
                p.Id AS [Mã sản phẩm],
                c.Name AS [Loại],
                p.Name AS [Tên sản phẩm],
                p.CalculationUnit AS [Đơn vị tính],
                p.PriceQuotation AS [Đơn giá],
                p.Quantity AS [Số lượng],
                p.CustomerWarranty AS [Bảo hành (tháng)],
                p.Description AS [Mô tả]
            FROM Product p
            JOIN Category c ON p.CatId = c.Id
            WHERE p.IsDeleted = 0
            ORDER BY p.Id";

            return db.ExecuteQuery(query);
        }

        public void Save(ProductDTO p)
        {
            string queryCheck = "SELECT COUNT(Id) FROM Product WHERE Id = @id";
            int exists = Convert.ToInt32(db.ExecuteScalar(queryCheck, new SqlParameter("@id", p.Id)));

            string query = exists > 0
                ? @"UPDATE Product SET CatId = @catId, Name = @name, CalculationUnit = @unit,
                         PriceQuotation = @price, Quantity = @quantity,
                         CustomerWarranty = @warranty, Description = @desc
                 WHERE Id = @id"
                : @"INSERT INTO Product (Id, CatId, Name, CalculationUnit, PriceQuotation, Quantity, CustomerWarranty, Description)
                VALUES (@id, @catId, @name, @unit, @price, @quantity, @warranty, @desc)";

            db.ExecuteNonQuery(query,
                new SqlParameter("@id", p.Id),
                new SqlParameter("@catId", p.CatId),
                new SqlParameter("@name", p.Name),
                new SqlParameter("@unit", p.CalculationUnit),
                new SqlParameter("@price", p.PriceQuotation),
                new SqlParameter("@quantity", p.Quantity),
                new SqlParameter("@warranty", p.CustomerWarranty),
                new SqlParameter("@desc", p.Description ?? ""));
        }

        public void Delete(string productId)
        {
            string query = "UPDATE Product SET IsDeleted = 1 WHERE Id = @id";
            db.ExecuteNonQuery(query, new SqlParameter("@id", productId));
        }

        public List<string> LoadComboBoxData(string query, string displayColumn)
        {
            return db.GetDataForComboBox(query, displayColumn);
        }

        public object GetLastProductId()
        {
            return db.ExecuteScalar("SELECT MAX(Id) FROM Product");
        }

        public void IncreaseQuantity(string id, int quantityToAdd)
        {
            string query = "UPDATE Product SET Quantity = Quantity + @Qty WHERE Id = @Id";
            db.ExecuteNonQuery(query, new SqlParameter("@Qty", quantityToAdd), new SqlParameter("@Id", id));
        }

        public DataTable GetProductsByCategoryId(string categoryId)
        {
            string query = "SELECT * FROM Product WHERE CatId = @CatId AND IsDeleted = 0";
            return db.ExecuteQuery(query, new SqlParameter("@CatId", categoryId));
        }
    }
}
