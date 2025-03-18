using GoshehArtWebApp.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.ViewModels
{
    public class CreatePageViewModel
    {
        
        [Required(ErrorMessage = "Page Title is required")]
        [Display(Name = "Asset Name:")]
        public string? Title { get; set; }
        [Display(Name = "Header Image for Page")]
        public string? Container { get; set; }
        [Display(Name = "Contents")]
        public List<int>? ContentIds { get; set; } = new();
        [Display(Name = "Content:")]
        public List<Content>? Contents { get; set; } = new();
    }
}
