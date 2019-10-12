using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class Passenger : User
    {
        public Seat Seat { get; set; }
        public ICollection<Order> Orders { get; set; }

        protected Passenger() : base()
        {
            Orders = new List<Order>();
        }

        public Passenger(string firstName, string lastName, Seat seat)
        : base(firstName, lastName)
        {
            Orders = new List<Order>();
            Seat = seat;
        }

        public override void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public override void RemoveOrder(Order order)
        {
            Orders.Remove(order);
        }
    }
}
