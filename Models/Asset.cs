using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoshehArtWebApp.Models
{
    public class Asset
    {
        [Key]
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        public string? Location { get; set; }

        // Vi behöver lägga till views och controller actions för dem här två nya propsen till modellen.
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? Date { get; set; }
		
        public string? ImageUrl { get; set; } 
		public int CategoryId { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
		[NotMapped]
		public IFormFile? ImageUp { get; set; } 

   

    }
}
