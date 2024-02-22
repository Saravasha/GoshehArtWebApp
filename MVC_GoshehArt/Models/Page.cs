using System.ComponentModel.DataAnnotations;

namespace MVC_GoshehArt.Models
{
    public class Page
    {
        [Key]
        public string Title { get; set; }
        public string Content {  get; set; }        
    }
}
