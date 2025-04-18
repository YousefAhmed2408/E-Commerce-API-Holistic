using System.ComponentModel.DataAnnotations;
using Web_Holistecc.DTO_s.CustomerDTO_s;
using Web_Holistecc.DTO_s.ProductDTO_s;
using Web_Holistecc.Models;

namespace Web_Holistecc.DTO_s.OrderDTO_s
{
    public class OrderGetAllDTO
    {
        [Required]
        public int TotalPrice { get; set; }

        public List<ProductDTO> products { get; set; } = [];

        public CustomerDTO Customer { get; set; }
    }
}
