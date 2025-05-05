using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{
    public class ImportDetailDTO
    {
        public string Id { get; set; }                  // Mã phiếu nhập
        public string ProId { get; set; }               // Mã sản phẩm
        public string ProName { get; set; }
        public int Quantity { get; set; }               // Số lượng
        public long Price { get; set; }                 // Đơn giá
        public string Unit { get; set; }
        public decimal Tax { get; set; }                // Thuế (0 - 1)
        public long Total { get; set; }                  // Tổng tiền
        public DateTime WarrantyDateEnd { get; set; }   // Hạn bảo hành
    }

}
