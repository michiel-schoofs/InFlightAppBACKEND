using InFlightAppBACKEND.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Data.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        IEnumerable<Order> GetAllUnprocessed();
        Order GetById(int id);
        void Add(Order order);
        void Remove(Order order);
        void SaveChanges();
    }
}
