using System.ComponentModel.DataAnnotations;

namespace Web_Holistecc.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Phone]
        public string CustomerPhone { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }

        public int ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public List<Order> orders { get; set; }

    }
}
