using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public ProductType Type { get; set; }

        protected Product()
        {

        }

        public Product(string name, string description, decimal unitPrice, ProductType type)
        {
            Name = name;
            Description = description;
            UnitPrice = unitPrice;
            Type = type;
        }
    }
}
