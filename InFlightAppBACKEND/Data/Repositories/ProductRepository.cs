using InFlightAppBACKEND.Data.Mappers;
using InFlightAppBACKEND.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InFlightAppBACKEND.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private DbSet<Product> _products;
        private DBContext _dbContext;

        public ProductRepository(DBContext dbContext)
        {
            _products = dbContext.Products;
            _dbContext = dbContext;
        }

        public IEnumerable<Product> GetAll()
        {
            return _products.Include(p => p.Type).ToList();
        }

        public Product GetById(int id)
        {
            return _products.Include(p => p.Type).SingleOrDefault(p => p.ProductId == id);
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Remove(Product product)
        {
            _products.Remove(product);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
