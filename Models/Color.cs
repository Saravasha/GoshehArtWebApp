using System.ComponentModel.DataAnnotations;


namespace GoshehArtWebApp.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Background Color")]
        public string? BgColor { get; set; }

        [Display(Name = "Gradient Range Color if set")]
        public string? GradientColor { get; set; }

    }
}
