using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class Message
    {
        public int MessageId { get; set; }
        public int ConversationId { get; set; }
        public int SenderId { get; set; }
        public string Content { get; set; }
        public DateTime DateSent { get; set; }

        protected Message()
        {

        }

        public Message(Conversation conversation, Passenger sender, string content)
        {
            ConversationId = conversation.ConversationId;
            SenderId = sender.UserId;
            Content = content;
            DateSent = DateTime.Now;
        }
    }
}
