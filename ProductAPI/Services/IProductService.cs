using ProductAPI.Models;
using System.Collections.Generic;

namespace ProductAPI.Services
{
    public interface IProductService
    {
        ProductEntity Get(int Id);
        List<ProductEntity> GetAll();
    }
}