using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CraftWebsite.Models
{
    public class Product
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("maker")]
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        public int[] Ratings { get; set; }

        public Product()
        {

        }

        //Equivalent to a normal method
        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}
