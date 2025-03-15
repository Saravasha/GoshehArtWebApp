using GoshehArtWebApp.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.ViewModels
{
    public class CreatePageViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Page Title")]
        public string Title { get; set; }
        [Display(Name = "Container Body")]
        public string? Container { get; set; }
        [Display(Name = "Contents")]
        public List<int> ContentIds { get; set; } = new();
        [Display(Name = "Content:")]
        public List<Content> Contents { get; set; } = new();
    }
}
