using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class Seat
    {
        public int SeatId { get; set; }
        public int FlightId { get; set; }
        public SeatType Type { get; set; }
        public Passenger Passenger { get; set; }

        protected Seat()
        {

        }

        public Seat(SeatType type, Passenger passenger)
        {
            Passenger = passenger;
        }
    }
}
