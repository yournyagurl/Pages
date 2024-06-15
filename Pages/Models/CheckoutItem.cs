using System.ComponentModel.DataAnnotations;

namespace Pages.Models
{
    public class CheckoutItem
    {
        [Key, Required]
        public int Id { get; set; }
        public int BookId { get; set; }

        public decimal Price { get; set; }

        public string Title { get; set; }

        public int BasketId { get; set; }

        public int Quantity { get; set; }
    }
}
