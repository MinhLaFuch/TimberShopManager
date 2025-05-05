using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.DTO
{

    public class ProductDTO
    {
        public static readonly string PREFIX = "P";
        public static readonly int CODE_LENGTH = 4;

        public string Id { get; set; }
        public string CatId { get; set; }
        public string Name { get; set; }
        public string CalculationUnit { get; set; }
        public double PriceQuotation { get; set; }
        public int Quantity { get; set; }
        public int CustomerWarranty { get; set; }
        public string Description { get; set; }

        // Parameterless constructor for flexibility in 3-tier architecture
        public ProductDTO() { }

        // Full constructor for complete initialization
        public ProductDTO(string id, string catId, string name, string unit, double price, int quantity, int warranty, string description)
        {
            Id = id;
            CatId = catId;
            Name = name;
            CalculationUnit = unit;
            PriceQuotation = price;
            Quantity = quantity;
            CustomerWarranty = warranty;
            Description = description;
        }
    }


}
