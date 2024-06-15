using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pages.Models
{
    public class BasketItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public BookModel BookModel { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
