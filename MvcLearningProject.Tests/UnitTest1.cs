using Xunit;
using MvcLearningProject.Repositories;
using System.Data.Common;
using System.Reflection;
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
    [Fact]
    public void GetById_ReturnsCorrectProduct()
    {
        // Arrange
        var productRepository = new ProductRepository();

        // Act
        var product = productRepository.GetById(2);

        // Assert
        Assert.NotNull(product);
        Assert.Equal("Keyboard", product.Name);
        
    }
    [Fact]
    public void GetById_ProductNotExist()
    {
        //Arrange       creating object
        var productRepository = new ProductRepository();

        //Act       checking tested method
        var product = productRepository.GetById(99);

        //Assert        
        Assert.Null(product);       //checking if variable is null
    }
}
