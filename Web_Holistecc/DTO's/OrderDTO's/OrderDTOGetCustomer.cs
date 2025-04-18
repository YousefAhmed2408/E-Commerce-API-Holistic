using System.ComponentModel.DataAnnotations;
using Web_Holistecc.DTO_s.ProductDTO_s;
using Web_Holistecc.Models;

namespace Web_Holistecc.DTO_s.OrderDTO_s
{
    public class OrderDTOGetCustomer
    {
        [Required]
        public int TotalPrice { get; set; }
        

        public List<ProductDTO> products { get; set; } = [];

    }
}
