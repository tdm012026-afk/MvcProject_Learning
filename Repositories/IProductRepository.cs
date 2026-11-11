using MvcLearningProject.Models;

namespace MvcLearningProject.Repositories;

public interface IProductRepository
{
    List<Product> GetAll();

    void Add(Product product);
}
