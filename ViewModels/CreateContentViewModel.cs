using GoshehArtWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.ViewModels
{
    public class CreateContentViewModel
    {

        [Required(ErrorMessage = "Content Title is required")]
        [Display(Name = "Content Title:")]
        public string? Title { get; set; }
        [Display(Name = "Content Header Image")]
        public string? Container { get; set; }
        public int PageId { get; set; }
        public List<int>? PageIds { get; set; } = new();
        public List<Page>? Pages { get; set; } = new();
    }
}
