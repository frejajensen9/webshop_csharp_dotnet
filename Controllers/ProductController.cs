using System.Collections.Generic;
using Webapp.WebSite.Models;
using Webapp.WebSite.Services;
using Microsoft.AspNetCore.Mvc;

namespace Webapp.WebSite.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService) =>
            ProductService = productService;

        public JsonFileProductService ProductService { get;}

        [HttpGet]
        public IEnumerable<Product> Get() => ProductService.GetProducts();
    }
}