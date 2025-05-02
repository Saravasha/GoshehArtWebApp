
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

    public string? Location { get; set; }

    // Vi behöver lägga till views och controller actions för dem här två nya propsen till modellen.
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? Date { get; set; }

    [Display(Name = "Asset Image")]
    public string? ImageUrl { get; set; }

    [Display(Name = "Asset Image")]
    [NotMapped]
    [Required(ErrorMessage = "Image is Required")]

    public IFormFile ImageUp { get; set; }

    public List<int>? CategoryIds { get; set; } = new();

    [Display(Name = "Category:")]
    public List<Category> Categories { get; set; } = new();
}