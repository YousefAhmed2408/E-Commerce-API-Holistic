using System.ComponentModel.DataAnnotations;
using Web_Holistecc.DTO_s.OrderDTO_s;
using Web_Holistecc.DTO_s.ShoppingCartDTO_s;
using Web_Holistecc.Models;

namespace Web_Holistecc.DTO_s.CustomerDTO_s
{
    public class CustomerDTOPost
    {
        [Required]
        public string? CustomerName { get; set; }
        [Phone]
        public string CustomerPhone { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }

        public ShoppingCartDTO ShoppingCart { get; set; }

        public List<OrderDTO> orders { get; set; }
    }
}
