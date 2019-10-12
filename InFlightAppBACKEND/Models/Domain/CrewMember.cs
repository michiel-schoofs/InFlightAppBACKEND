using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class CrewMember : User
    {
        protected CrewMember() : base() { }

        public CrewMember(string firstName, string lastName)
        : base(firstName, lastName) { }
    }
}
