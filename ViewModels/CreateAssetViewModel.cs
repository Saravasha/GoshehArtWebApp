
using GoshehArtWebApp.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace GoshehArtWebApp.ViewModels;

public class CreateAssetViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Asset Name is required")]
    [Display(Name = "Asset Name:")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Author is required")]
    [Display(Name = "Author:")]
    public string? Author { get; set; }

    [Display(Name = "Description:")]
    public string? Description { get; set; }


    [Display(Name = "Asset Image")]
    public string? ImageUrl { get; set; }

    [Display(Name = "Asset Image")]
    [NotMapped]
    [Required(ErrorMessage = "Image is Required")]
    public IFormFile ImageUp { get; set; }

    public List<int>? CategoryIds { get; set; } = new();

    [Display(Name = "Category:")]
    [Required(ErrorMessage = "Category is Required")]
    public List<Category> Categories { get; set; } = new();
}