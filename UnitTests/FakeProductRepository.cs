namespace UnitTests;

using CS295_FinalProject.Data;
using CS295_FinalProject.Models;
public class FakeProductRepository
{
    public class FakeProduct : IProductRepository
    {
        private List<Product> Products { get; set; } = new List<Product>();
        
        public List<Product> GetAllProducts()
        {
            return Products;
        }

        public Product GetProductById(int id)
        {
            return Products[id];
        }

        public int StoreProduct(Product model)
        {
            int status = 0;
            
            if (model != null)
            {
                model.Id = Products.Count + 1;
                Products.Add(model);
                status = 1;
            }

            return status;
        }
    }
}