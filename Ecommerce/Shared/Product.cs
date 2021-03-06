using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Shared
{
    public class Product
    {

        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18, 2")]
        public decimal Price { get; set; }
        public Product(int id, string title, string description, string imageUrl, decimal price)
        {
            Id = id;
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
            Price = price;
        }

    }
}
