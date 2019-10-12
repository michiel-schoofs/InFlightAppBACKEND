using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class Passenger : User
    {
        public Seat Seat { get; set; }
        public TravelGroup TravelGroup { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<PassengerConversation> PassengerConversations { get; set; }

        protected Passenger() : base()
        {
            Orders = new List<Order>();
            PassengerConversations = new List<PassengerConversation>();
        }

        public Passenger(string firstName, string lastName, Seat seat, TravelGroup travelGroup)
        : base(firstName, lastName)
        {
            Seat = seat;
            TravelGroup = travelGroup;
            Orders = new List<Order>();
            PassengerConversations = new List<PassengerConversation>();
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
