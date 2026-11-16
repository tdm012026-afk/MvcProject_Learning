using Xunit;
using MvcLearningProject.Repositories;
namespace MvcLearningProject.Tests;

public class UnitTest1
{
    [Fact]
    public void GetAll_ReturnsAllProducts()
    {
        // Arrange
        var productRepository = new ProductRepository();

        // Act 
        var products = productRepository.GetAll();

        //Assert
        Assert.Equal(3, products.Count);
    }
}
