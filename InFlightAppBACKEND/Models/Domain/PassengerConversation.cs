using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class PassengerConversation
    {
        public int PassengerId { get; set; }
        public int ConversationId { get; set; }
        public Passenger Passenger { get; set; }
        public Conversation Conversation { get; set; }

        protected PassengerConversation()
        {
        }

        public PassengerConversation(Passenger passenger, Conversation conversation)
        {
            PassengerId = passenger.UserId;
            ConversationId = conversation.ConversationId;
            Passenger = passenger;
            Conversation = conversation;
        }
    }
}
