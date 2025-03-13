using GoshehArtWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.ViewModels
{
    public class CreatePageViewModel
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Container { get; set; }

        public List<int> ContentIds { get; set; } = new();
        [Display(Name = "Content:")]
        [Required(ErrorMessage = "Content is Required")]
        public List<Content> Contents { get; set; } = new();
    }
}
