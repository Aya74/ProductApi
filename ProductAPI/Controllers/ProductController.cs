using Microsoft.AspNetCore.Mvc;
using ProductAPI.Dtos;
using ProductAPI.Services;

namespace ProductAPI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_productService.GetAll());
        }
        [HttpGet]
        public IActionResult Get(int Id)
        {
            return Ok(_productService.Get(Id));
        }
    }
}
