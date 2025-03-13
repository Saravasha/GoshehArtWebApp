using GoshehArtWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.ViewModels
{
    public class PageViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Page Title")]
        public string Title { get; set; }
        public string Container { get; set; }

        public Content Content { get; set; }
        public List<int> ContentIds { get; set; } = new();
        public List<Content> Contents { get; set; } = new();

        public List<Page> Pages { get; set; } = new();
    }
}
