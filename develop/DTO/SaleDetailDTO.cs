using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{
    public class SaleDetailDTO
    {
        public string InvoiceId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public DateTime WarrantyEnd { get; set; }

        public SaleDetailDTO(string invoiceId, string productId, int quantity, decimal price, decimal tax, decimal total, DateTime warrantyEnd)
        {
            InvoiceId = invoiceId;
            ProductId = productId;
            Quantity = quantity;
            Price = price;
            Tax = tax;
            Total = total;
            WarrantyEnd = warrantyEnd;
        }
    }

}
