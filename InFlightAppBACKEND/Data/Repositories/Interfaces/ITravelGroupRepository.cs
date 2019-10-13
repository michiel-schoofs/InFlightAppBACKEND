using InFlightAppBACKEND.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Data.Repositories
{
    public interface ITravelGroupRepository
    {
        IEnumerable<TravelGroup> GetAll();
        IEnumerable<Message> GetMessagesFromTravelGroup(int id);
        IEnumerable<Passenger> GetPassengersFromTravelGroup(int id);
        TravelGroup GetById(int id);
        void Add(TravelGroup travelGroup);
        void Remove(TravelGroup travelGroup);
        void SaveChanges();
    }
}
