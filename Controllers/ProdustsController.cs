using Microsoft.AspNetCore.Mvc;
using MvcLearningProject.Models;
using MvcLearningProject.Repositories;

namespace MvcLearningProject.Controllers;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        ProductRepository repository = new ProductRepository();

        List<Product> products = repository.GetAll();

        return View(products);
    }
}