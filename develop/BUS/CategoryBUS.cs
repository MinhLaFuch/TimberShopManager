using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using timber_shop_manager.DAL;
using timber_shop_manager.DTO;

namespace timber_shop_manager.BUS
{
    public class CategoryBUS
    {
        private CategoryDAL dal = new();

        public DataTable GetAllCategories()
        {
            return dal.GetAllCategories();
        }

        public void SaveCategory(CategoryDTO c)
        {
            if (string.IsNullOrWhiteSpace(c.Id) || string.IsNullOrWhiteSpace(c.Name))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã và Tên danh mục.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dal.InsertOrUpdate(c);
        }

        public void DeleteCategory(CategoryDTO c)
        {
            if (c == null) return;

            var confirm = MessageBox.Show("Bạn có chắc chắn muốn xoá danh mục này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                dal.Delete(c);
            }
        }

        public string GetCategoryNameById(string id)
        {
            var dt = GetAllCategories();
            var row = dt.AsEnumerable()
                        .FirstOrDefault(r => r.Field<string>("Mã danh mục").Equals(id, StringComparison.OrdinalIgnoreCase));
            return row?["Tên"].ToString();
        }

        public string GetCategoryIdByName(string categoryName)
        {
            var categoryTable = new CategoryBUS().GetAllCategories();
            var catRow = categoryTable.AsEnumerable()
                                      .FirstOrDefault(r => r.Field<string>("Tên").Equals(categoryName, StringComparison.OrdinalIgnoreCase));
            return catRow?["Mã danh mục"].ToString();
        }

        public void Insert(CategoryDTO dto)
        {
            dal.Insert(dto);
        }

        public string GenerateNewCategoryId()
        {
            string lastId = dal.GetLastCategoryId();
            return Program.GenerateNextCode(lastId, CategoryDTO.PREFIX, CategoryDTO.CODE_LENGTH);
        }
    }
}
