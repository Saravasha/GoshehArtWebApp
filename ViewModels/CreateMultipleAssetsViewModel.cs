
using GoshehArtWebApp.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace GoshehArtWebApp.ViewModels;
public class CreateMultipleAssetsViewModel : ResponseModel
{


    //public List<CreateAssetViewModel> CreateAssets { get; set; }
    public List<int> Id { get; set; }


    public string? Name { get; set; }

    public string? Author { get; set; }
    public string? Description { get; set; }

    public string? Location { get; set; }

    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? Date { get; set; }
    public string? ImageUrl { get; set; }

    [NotMapped]
    public List<IFormFile> ImageUp { get; set; }

    public List<int>? CategoryId { get; set; } = new();

    public List<Category>? Categories { get; set; } = new();
}
