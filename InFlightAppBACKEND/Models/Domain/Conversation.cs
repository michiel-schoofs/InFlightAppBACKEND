using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class Conversation
    {
        public int ConversationId { get; set; }
        public ICollection<PassengerConversation> PassengerConversations { get; set; }
        public ICollection<Message> Messages { get; set; }

        public Conversation()
        {
            PassengerConversations = new List<PassengerConversation>();
            Messages = new List<Message>();
        }
        
        public void AddPassengerConversation(Passenger passenger)
        {
            PassengerConversation pc = new PassengerConversation(passenger, this);
            PassengerConversations.Add(pc);
        }

    }
}
