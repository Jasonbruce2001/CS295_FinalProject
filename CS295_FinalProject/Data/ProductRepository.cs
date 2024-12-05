using CS295_FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CS295_FinalProject.Data;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext appDbContext)
    {
        _context = appDbContext;
    }

    public List<Product> GetAllProducts()
    {
        var products = _context.Products
            .ToList<Product>();
        return products;
    }
   
    public Product GetProductById(int id)
    {
        var product = _context.Products
            .Where(product => product.Id == id)
            .SingleOrDefault();
        return product;
    }
   
    public int StoreProduct(Product model)
    {
        _context.Products.Add(model);
        return _context.SaveChanges();
        // returns a positive value if successful
    }
}