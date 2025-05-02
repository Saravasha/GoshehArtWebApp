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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
        public string? Container { get; set; }
        public int? PageId { get; set; }
        public Page? Page { get; set; }

    }
}
