using System.ComponentModel.DataAnnotations;

namespace Web_Holistecc.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ShoppingCartId { get; set; }
        [Required]
        public int NumsOfItems { get; set; }

        public Customer? Customer { get; set; }
    }
}
