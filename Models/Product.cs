using System.ComponentModel.DataAnnotations;

namespace MvcLearningProject.Models;

public class Product
{
    public int Id {get; set;}

    [Required(ErrorMessage = "Product name is required")]
    public string Name {get; set;} = string.Empty;
    [Range(0.001, 1000000, ErrorMessage = "Price must be greater than Zero")]
    public decimal Price {get; set;}


}