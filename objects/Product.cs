using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timber_shop_manager.objects
{
    internal class Product
    {
        public static readonly int SOLD_OUT = 0;
        public static readonly string PREFIX = "SI";
        public static readonly int CODE_LENGTH = 6;

        private string id, name, unit, description;
        private double price;
        private int warranty, quantity;

        public Product(string id, string name, string unit, double price, int warranty, string description, int quantity)
        {
            this.id = id;
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
    }
}
