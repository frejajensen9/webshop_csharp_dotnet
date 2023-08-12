using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Webapp.WebSite.Models;

namespace Webapp.WebSite.Services
{
    public class JsonFileProductService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly string _jsonFileName;

        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _jsonFileName = Path.Combine(_webHostEnvironment.WebRootPath, "data", "products.json");
        }

        public IEnumerable<Product> GetProducts()
        {
            using var jsonFileReader = File.OpenText(_jsonFileName);
            return JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }

        public Product GetProductById(string id)
        {
            var products = GetProducts();
            return products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
