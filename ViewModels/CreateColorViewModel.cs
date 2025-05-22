using System.ComponentModel.DataAnnotations;


namespace GoshehArtWebApp.ViewModels
{
    public class CreateColorViewModel
    {

        public int Id { get; set; }
        
        [Required(ErrorMessage = "Color Name is required")]
        [Display(Name = "Color Name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Start Color is required")]
        [Display(Name = "Start Color")]
        public string StartColor { get; set; }

        [Required(ErrorMessage = "End Color is required")]
        [Display(Name = "End Color (Set to the same as Start Color if you want don't want gradient)")]
        public string EndColor { get; set; }
        [Required(ErrorMessage = "Dark Start Color is required")]
        [Display(Name = "Dark Start Color")]
        public string DarkStartColor { get; set; }
        [Required(ErrorMessage = "Dark End Color is required")]
        [Display(Name = "Dark End Color (Set to the same as Start Color if you want don't want gradient)")]
        public string DarkEndColor { get; set; }

    }
}
