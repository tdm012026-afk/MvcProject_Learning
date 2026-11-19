using MvcLearningProject.Models;
using Xunit;
using MvcLearningProject.Repositories;
using System.Data.Common;
using System.Reflection;
using System.Net.Http.Headers;
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
    [Fact]
    public void Add_NewProduct()
    {
        // Arrange
        var productRepository = new ProductRepository();
        var product = new Product
        {
            Name = "Monitor",
            Price = 1200m
        };
        //Act 
        productRepository.Add(product);
       
       //Assert
       var products = productRepository.GetAll();
       Assert.Equal(4, products.Count);
    }
    [Fact]
    public void Update_ExistingProduct()
    {
        //Arrange
        var productRepository = new ProductRepository();
        var product = productRepository.GetById(1);
        Assert.NotNull(product);
        product.Price = 8000m;
        product.Name = "Updated Laptop";
        
        // Act
        productRepository.Update(product);

        //Assert
        var updatedProduct = productRepository.GetById(1);
        
        Assert.NotNull(updatedProduct);
        Assert.Equal(8000m, updatedProduct.Price);
    
    }
}