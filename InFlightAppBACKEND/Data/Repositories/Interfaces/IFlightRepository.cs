using InFlightAppBACKEND.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Data.Repositories
{
    public interface IFlightRepository
    {
        IEnumerable<Flight> GetAll();
        IEnumerable<Passenger> GetPassengersFromFlight(int id);
        Flight GetById(int id);
        void Add(Flight flight);
        void Remove(Flight flight);
        void SaveChanges();
    }
}
