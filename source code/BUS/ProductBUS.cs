using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timber_shop_manager.DAL;
using timber_shop_manager.DTO;

namespace timber_shop_manager.BUS
{
    public class ProductBUS
    {
        private readonly ProductDAL dal = new();
        private readonly CategoryBUS categoryBUS = new CategoryBUS();

        public DataTable GetAllProducts() => dal.GetAll();

        public void SaveProduct(ProductDTO product) => dal.Save(product);

        public void DeleteProduct(string id) => dal.Delete(id);

        public List<string> GetCategories() => dal.LoadComboBoxData("SELECT DISTINCT Name FROM Category", "Name");

        public List<string> GetUnits() => dal.LoadComboBoxData("SELECT DISTINCT CalculationUnit FROM Product", "CalculationUnit");

        public string GenerateNextProductId()
        {
            string lastId = Convert.ToString(dal.GetLastProductId());
            return Program.GenerateNextCode(lastId, ProductDTO.PREFIX, ProductDTO.CODE_LENGTH);
        }

        public ProductDTO GetProductByName(string name)
        {
            var dt = dal.GetAll();
            var row = dt.AsEnumerable()
                        .FirstOrDefault(r => r.Field<string>("Tên sản phẩm").Equals(name, StringComparison.OrdinalIgnoreCase));
            if (row == null) return null;

            return new ProductDTO
            {
                Id = row["Mã sản phẩm"].ToString(),
                Name = row["Tên sản phẩm"].ToString(),
                CatId = categoryBUS.GetCategoryIdByName(row["Loại"].ToString()),
                CalculationUnit = row["Đơn vị tính"].ToString(),
            };
        }

        public void IncreaseQuantity(string id, int quantityToAdd)
        {
            dal.IncreaseQuantity(id, quantityToAdd);
        }

        public DataTable GetProductsByCategoryId(string id)
        {
            return dal.GetProductsByCategoryId(id);
        }
    }
}
