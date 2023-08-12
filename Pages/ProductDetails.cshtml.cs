using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webapp.WebSite.Models;
using Webapp.WebSite.Services;

namespace Webapp.WebSite.Pages
{
    public class ProductDetailsModel : PageModel
    {
        private readonly ILogger<ProductDetailsModel> _logger;

        public ProductDetailsModel(ILogger<ProductDetailsModel> logger,
            JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }
        public IEnumerable<Product>? Products { get; private set; }
        public Product Product { get; private set; }

        public void OnGet() => Product = ProductService.GetProductById("p1");
    }
}
