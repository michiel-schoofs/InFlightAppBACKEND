using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class Notification
    {
        public int NotificationId { get; set; }
        public int CrewMemberId { get; set; }
        public ICollection<int> Receivers { get; set; }
        public string Content { get; set; }

        protected Notification()
        {
            Receivers = new List<int>();
        }

        public Notification(int sender, List<int> receivers, string content)
        {
            CrewMemberId = sender;
            Receivers = receivers;
            Content = content;
        }
    }
}
