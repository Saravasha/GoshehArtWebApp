using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.Models
{
    public class Content
    {


        public int Id { get; set; }
        [Required]
        [Display(Name = "Content Title")]
        public string? Title { get; set; }
        [Display(Name = "Container Body")]
        public string? Container { get; set; }
        public int PageId { get; set; } = 0;
        public Page? Page { get; set; }

    }
}
