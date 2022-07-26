using ProductAPI.Data;
using ProductAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProductAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _db;
        public ProductService(ApplicationDbContext db)
        {
            _db = db;
        }
        public List<ProductEntity> GetAll()
        {
            var products = _db.Products.ToList();
            return products;
        }
        public ProductEntity Get(int Id)
        {
            var product = _db.Products.Find(Id);
            return product;
        }
    }
}
