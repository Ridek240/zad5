
using System.ComponentModel.DataAnnotations;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace zad5.Model
{
    public class Products
    {
        public string Id { get; set; }
        [MaxLength(150)]
        public string Maker { get; set; }
        [JsonPropertyName("img")]
        [MaxLength(150)]
        public string Image { get; set; }
        [MaxLength(150)]
        public string Title { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }

        public override string ToString()=> JsonSerializer.Serialize<Products>(this);
 
    }
}
