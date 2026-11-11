using MvcLearningProject.Models;

namespace MvcLearningProject.Repositories;

public class ProductRepository : IProductRepository
{
    public List<Product> GetAll()
    {
        List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 7500m
            },
            new Product
            {
                Id = 2,
                Name = "Keyboard",
                Price = 250m
            },
            new Product
            {
                Id = 3,
                Name = "Mouse",
                Price = 150m
            }
        };

        return products;
    }
}