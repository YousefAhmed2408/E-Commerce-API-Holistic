using System.ComponentModel.DataAnnotations;
using Web_Holistecc.DTO_s.OrderDTO_s;
using Web_Holistecc.DTO_s.ShoppingCartDTO_s;

namespace Web_Holistecc.DTO_s.CustomerDTO_s
{
    public class CustomerGetByIdDTO
    {
        [Required]
        public string? CustomerName { get; set; }
        [Phone]
        public string CustomerPhone { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }

        public ShoppingCartDTO ShoppingCart { get; set; }

        public List<OrderDTOGetCustomer> orders { get; set; }
    }
}
