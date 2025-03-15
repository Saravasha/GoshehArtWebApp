using GoshehArtWebApp.Models;
using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.ViewModels
{
    public class CreateContentViewModel
    {

        public ContentViewModel NewContent { get; set;} = new ContentViewModel();
        [Display(Name = "Pages")]
        public List<Page> Pages { get; set; } = new();
    }
}
