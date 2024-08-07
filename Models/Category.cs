using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GoshehArtWebApp.Models
{
    
    //[Index(IsUnique =true)]
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public List<Asset> Assets { get; set; } = new List<Asset>();

    }
}
