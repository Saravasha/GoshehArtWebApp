using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.Models
{
    public class Content
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Content Title")]
        public string? Title { get; set; }
        public string? Body { get; set; }

        public int? PageId { get; set; }
        public Page? Page { get; set; } = default!;

    }
}
