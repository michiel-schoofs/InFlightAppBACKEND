using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class TravelGroup
    {
        public int TravelGroupId { get; set; }
        public Conversation Conversation { get; set; }
        public ICollection<Passenger> Passengers { get; set; }

        protected TravelGroup()
        {
            Passengers = new List<Passenger>();
            Conversation = new Conversation();
        }

        public TravelGroup(List<Passenger> passengers)
        {
            Passengers = passengers;
            Conversation = new Conversation();
        }

        public void sendMessage(Passenger passenger, string content)
        {
            Conversation.sendMessage(passenger, content);
        }
    }
}
