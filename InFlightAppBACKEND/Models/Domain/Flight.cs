using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Models.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string FlightNr { get; set; }
        public string Plane { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public ICollection<Seat> Seats { get; set; }

        public double ETA { get { return (ArrivalTime - DateTime.Now).TotalHours; } }
        public int Altitude { get { return new Random().Next(0, 40000); } }
        public int Speed { get { return new Random().Next(0, 500); } }
        public int NrOfSeats { get { return Seats.Count; } }

        protected Flight()
        {
            Seats = new List<Seat>();
        }

        public Flight(string flightNr, string plane, DateTime departureTime, DateTime arrivalTime, string origin, string destination)
        {
            FlightNr = flightNr;
            Plane = plane;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            Origin = origin;
            Destination = destination;
            Seats = new List<Seat>();
        }

        public void AddSeat(Seat seat)
        {
            Seats.Add(seat);
        }

    }
}
