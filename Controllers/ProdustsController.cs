using Microsoft.AspNetCore.Mvc;
using MvcLearningProject.Models;

namespace MvcLearningProject.Controllers;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        Product product = new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 3500m,
        };
        
        return View(product);
    }
}