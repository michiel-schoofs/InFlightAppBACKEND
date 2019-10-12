using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class Seat
    {
        public int SeatId { get; set; }
        public SeatType SeatType { get; set; }
        public int PassengerId { get; set; }

        protected Seat()
        {

        }

        public Seat(SeatType seatType, int passengerId)
        {
            SeatType = seatType;
            PassengerId = passengerId;
        }
    }
}
