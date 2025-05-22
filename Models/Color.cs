using System.ComponentModel.DataAnnotations;


namespace GoshehArtWebApp.Models
{
    public class Color
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string StartColor { get; set; }

        public string EndColor { get; set; }

        public string DarkStartColor { get; set; }
        
        public string DarkEndColor { get; set; }


    }
}
