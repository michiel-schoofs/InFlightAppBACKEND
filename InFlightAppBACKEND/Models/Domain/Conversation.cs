using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class Conversation
    {
        public int ConversationId { get; set; }
        public int TravelGroupId { get; set; }
        public ICollection<Message> Messages { get; set; }

        public Conversation()
        {
            Messages = new List<Message>();
        }

        public void sendMessage(Passenger sender, string content)
        {
            Messages.Add(new Message(this, sender, content));
        }
    }
}
