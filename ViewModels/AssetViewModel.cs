using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GoshehArtWebApp.Models;

namespace GoshehArtWebApp.ViewModels
{
    public class AssetViewModel 
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Asset Name")]
        public string Name { get; set; }
        public string? Author { get; set; }
        public string Description { get; set; }
        public Category Category { get; set; }
        public List<int>? CategoryIds { get; set; } = new();
        public List<Category> Categories { get; set; } = new();
        public List<Asset> Assets { get; set; } = new();
    }
}
