using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
//use thin controllers that call a class/service to acces the db, or some task
//not fat controller
namespace Ecommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetProduct()
        {
            var result  = await _productService.GetProductsAsync(); 
            return Ok(result );
        }
    }
}
