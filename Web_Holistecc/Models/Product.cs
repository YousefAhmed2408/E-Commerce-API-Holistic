using System.ComponentModel.DataAnnotations;

namespace Web_Holistecc.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [MaxLength(100)]
        public string ProductDescription { get; set; } = string.Empty;
        [Required]
        public int Quantity { get; set; }

        public List<Order> orders { get; set; } = [];
    }
}
