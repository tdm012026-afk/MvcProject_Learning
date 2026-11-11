using Microsoft.AspNetCore.Mvc;
using MvcLearningProject.Models;
using MvcLearningProject.Repositories;

namespace MvcLearningProject.Controllers;

public class ProductsController : Controller
{
    private readonly IProductRepository _repository;

    public ProductsController(IProductRepository repository)
    {
        _repository = repository;
    }
    public IActionResult Index()
    {
        List<Product> products = _repository.GetAll();

        return View(products);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Product product)
    {
        if (!ModelState.IsValid)
        {
            return View(product);
        }
        _repository.Add(product);

        return RedirectToAction("Index");
    }
}