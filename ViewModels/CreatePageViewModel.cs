using GoshehArtWebApp.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.ViewModels
{
    public class CreatePageViewModel
    {
        
        [Required(ErrorMessage = "Page Title is required")]
        [Display(Name = "Page Title:")]
        public string? Title { get; set; }
        [Display(Name = "Header Image for Page")]
        public string? Container { get; set; }
        [Display(Name = "Contents")]
        public List<int>? ContentIds { get; set; } = new();
        [Required(ErrorMessage = "Page Parent is required, else the Content has nowhere to appear")]
        [Display(Name = "Content:")]
        public List<Content>? Contents { get; set; } = new();
    }
}
