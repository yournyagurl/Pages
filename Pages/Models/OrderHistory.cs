using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Pages.Models
{
    public class OrderHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderNo { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime DateOfOrder { get; set; }

        public OrderHistory() { 
            DateOfOrder = DateTime.Now;
        }

    }
}
