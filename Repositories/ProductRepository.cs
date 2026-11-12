using MvcLearningProject.Models;
using System.Linq;
namespace MvcLearningProject.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly List<Product> _products = new List<Product>
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
    public List<Product> GetAll()
    {
        return _products;
    }
    public Product? GetById(int id)
    {
        return _products.FirstOrDefault(p => p.Id == id);
    }
    public void Add(Product product)
    {
        product.Id = _products.Max(p => p.Id) +1;
        
        _products.Add(product);
    }
    public void Update(Product product)
    {
        var existingProduct = GetById(product.Id);

        if (existingProduct == null)
        {
            return; 
        }
        existingProduct.Name = product.Name;
        existingProduct.Price = product.Price;
    }
    public void Delete(int id)
    {
        var product = GetById( id);

        if (product == null)
        {
            return;
        }
        _products.Remove(product);
    }
}