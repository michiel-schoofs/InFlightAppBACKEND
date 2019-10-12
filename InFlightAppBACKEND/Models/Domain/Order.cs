using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class Order
    {
        public int OrderId { get; set; }
        public int PassengerId { get; set; }
        public DateTime OrderDate { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }

        protected Order()
        {
            OrderLines = new List<OrderLine>();
        }

        public Order(int passengerId)
        {
            PassengerId = passengerId;
            OrderDate = DateTime.Now;
            OrderLines = new List<OrderLine>();
        }

        public void AddOrderLine(Product product, int amount)
        {
            OrderLine orderLine = new OrderLine(this, product, amount);
            OrderLines.Add(orderLine);
        }

        public void RemoveOrderLine(Product product)
        {
            OrderLine orderLine = OrderLines.SingleOrDefault(ol => ol.ProductId == product.ProductId);
            OrderLines.Remove(orderLine);
        }

    }
}
