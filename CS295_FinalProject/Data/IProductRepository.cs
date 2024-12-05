using CS295_FinalProject.Models;

namespace CS295_FinalProject.Data;

public interface IProductRepository
{
    public List<Product> GetAllProducts();  // Returns all product objects
    public Product GetProductById(int id); // Returns a model object
    public int StoreProduct(Product model);  // Saves a model object to the db
}