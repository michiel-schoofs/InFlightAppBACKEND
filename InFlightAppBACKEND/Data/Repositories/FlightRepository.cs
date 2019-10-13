using InFlightAppBACKEND.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Data.Repositories
{
    public class FlightRepository : IFlightRepository
    {
        private DbSet<Flight> _flights;
        private DBContext _dbContext;

        public FlightRepository(DBContext dbContext)
        {
            _flights = dbContext.Flights;
            _dbContext = dbContext;
        }



        public IEnumerable<Flight> GetAll()
        {
            return _flights.ToList();
        }

        public IEnumerable<Passenger> GetPassengersFromFlight(int id)
        {
            return _flights.SingleOrDefault(f => f.FlightId == id).Seats.Select(s => s.Passenger).ToList();
        }

        public Flight GetById(int id)
        {
            return _flights.SingleOrDefault(f => f.FlightId == id);
        }

        public void Add(Flight flight)
        {
            _flights.Add(flight);
        }

        public void Remove(Flight flight)
        {
            _flights.Remove(flight);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
