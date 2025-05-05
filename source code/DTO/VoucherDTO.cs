using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{
    public class VoucherDTO
    {
        // Properties representing the Voucher table structure
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }
        public decimal Percentant { get; set; }  // Discount as a fraction (e.g., 0.15 for 15%)
        public int Price { get; set; }         // Discount in fixed amount (if used)

        public VoucherDTO() { }

        public VoucherDTO(string id, string name, DateTime startDate, DateTime endDate, string description, decimal percentant, int price)
        {
            Id = id?.Trim().ToUpper();
            Name = name?.Trim();
            StartDate = startDate;
            EndDate = endDate;
            Description = description?.Trim();
            Percentant = percentant;
            Price = price;
        }
    }
}
