namespace Ecommerce.Server.Services.ProductServices;

public class ProductService: IProductService
{
    private readonly DataContext _context;
    public ProductService(DataContext context)
    {
        _context = context;
    }

    public async Task<ServiceResponse<List<Product>>> GetProductsfAsync()
    {
        var response = new ServiceResponsef<List<Product>>
        {
            Data = await _context.Products.ToListAsync()
        };

        return response;
    }

}