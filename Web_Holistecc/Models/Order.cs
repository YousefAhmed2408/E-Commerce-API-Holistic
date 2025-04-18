using System.ComponentModel.DataAnnotations;

namespace Web_Holistecc.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int TotalPrice { get; set; }

        public List<Product> products { get; set; } = [];

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
