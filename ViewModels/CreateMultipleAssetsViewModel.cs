
using GoshehArtWebApp.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace GoshehArtWebApp.ViewModels;
public class CreateMultipleAssetsViewModel
{


    public List<CreateAssetViewModel> CreateAssets { get; set; }
    public List<int> Ids { get; set; }


    public List<string>? Names { get; set; }

    public List<string>? Authors { get; set; }
    public List<string>? Descriptions { get; set; }

    public List<string>? ImagesUrl { get; set; }

    [NotMapped]
    public List<IFormFile> ImageUp { get; set; }

    public List<int>? CategoryIds { get; set; } = new();

    public List<Category> Categories { get; set; } = new();
}
