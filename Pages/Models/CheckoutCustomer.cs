using System.ComponentModel.DataAnnotations;

namespace Pages.Models
{
    public class CheckoutCustomer
    {
        [Key]
        [StringLength(50)]
        public string Email { get; set; }

        public string Name { get; set; }

        public int BasketId { get; set; }
    }
}
