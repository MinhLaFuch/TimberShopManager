using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{
    public class InvoiceDetailDTO
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public long Price { get; set; }
        public int Quantity { get; set; }
        public string Unit { get; set; }
        public long Total { get; set; }
        public DateTime WarrantyEnd { get; set; }
    }

}
