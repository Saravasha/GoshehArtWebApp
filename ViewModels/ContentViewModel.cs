using GoshehArtWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.ViewModels
{

    public class ContentViewModel
    {


        public int Id { get; set; }
        [Required]
        [Display(Name = "Content Title")]
        public string? Title { get; set; }
        [Display(Name = "Container Body")]
        public string? Body { get; set; }
        public int PageId { get; set; }
        public string? PageTitle { get; set; }
        public Page? Page { get; set; }
        public List<Content> Contents { get; set; } = new List<Content>();
        public List<Page>? Pages { get; set; } = new();

    }
}
