using GoshehArtWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.ViewModels
{

    public class ContentViewModel
    {

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public int PageId { get; set; }
        public string PageTitle { get; set; }
        public Page Page { get; set; } = default!;

        public List<Page> Pages { get; set; } = new();
        public List<Content> Contents { get; set; } = new();
    }
}
