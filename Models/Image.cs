using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVC_GoshehArt.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        [NotMapped]
        public IFormFile ImageUp { get; set; }

        public int CategoryId { get; set; }
        public List<Category> Categories { get; set; } = new();
    }
}
