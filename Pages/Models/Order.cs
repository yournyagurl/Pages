using System.ComponentModel.DataAnnotations;

namespace Pages.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderNo { get; set; }

        [Required]
        public int BookId { get; set; }

        [Required]
        public int Quantity { get; set; }

        public BookModel BookModel { get; set; }
    }
}
