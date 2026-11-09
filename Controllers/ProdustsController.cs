using Microsoft.AspNetCore.Mvc;
using MvcLearningProject.Models;

namespace MvcLearningProject.Controllers;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Price = 7500m,
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
                Price = 150m,
            },
        };
        
        return View(products);
    }
}