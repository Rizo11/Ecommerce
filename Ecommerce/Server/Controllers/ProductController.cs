using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>()
        {
            new Product(1, "Cheetah", "MIT’s new mini cheetah robot is springy and light on its feet, with a range of motion that rivals a champion gymnast. The four-legged powerpack can bend and swing its legs wide, enabling it to walk either right-side up or upside down. The robot can also trot over uneven terrain about twice as fast as an average person’s walking speed.",
            "https://robots.ieee.org/robots/minicheetah/minicheetah-thumb@2x.jpg", 100),
            new Product(2, "Spot", "Spot is an agile mobile robot that navigates terrain with unprecedented mobility, allowing you to automate routine inspection tasks and data capture safely, accurately, and frequently. The results? Safer, more efficient and more predictable operations.",
            "https://static.wikia.nocookie.net/robotics/images/6/64/38AB8AB0-0E22-4200-A4A6-382335BEEC5E.jpeg", 111),
            new Product(3, "Atlas", "Atlas has one of the world’s most compact mobile hydraulic systems. A custom battery, valves, and a compact hydraulic power unit enable Atlas to deliver high power to any of its 28 hydraulic joints for impressive feats of mobility.",
            "https://i.pinimg.com/originals/d3/33/3f/d3333fc913a33c7d3bde8ee006dc1323.png", 299),
        }; 

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }
}
