using System.ComponentModel.DataAnnotations;

namespace Pages.Models
{
    public class BookModel
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Description { get; set; }


    }
}
