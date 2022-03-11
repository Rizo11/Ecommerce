using System.Threading.Tasks;
namespace Ecommerce.Server.Services.ProductServices;

public interface IProductService
{
    Task<ServiceResponse<List<Product>>> GetProductsAsync();
}