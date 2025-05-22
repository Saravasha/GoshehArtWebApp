
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace GoshehArtWebApp.Models
{
    public class Asset
    {
        [Key]
        public int Id { get; set; } 
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Location { get; set; }
        [JsonIgnore]
        public DateOnly? Date { get; set; }
        public string? DateString => Date?.ToString("yyyy-MM-dd");
        public string? ImageUrl { get; set; } 
		public int CategoryId { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
		[NotMapped]
		public IFormFile? ImageUp { get; set; } 
    }
}
