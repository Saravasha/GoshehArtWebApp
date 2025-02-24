using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.Models
{
    public class Page
    {
        [Key]
        public string? Title { get; set; }
        public string? Content { get; set; }
    }
}
