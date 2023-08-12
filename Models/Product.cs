using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Webapp.WebSite.Models
{
	public class Product
	{
        [JsonPropertyName("id")]
        public string ProductId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }


        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}

