using System.ComponentModel.DataAnnotations;
using Web_Holistecc.DTO_s.ProductDTO_s;

namespace Web_Holistecc.DTO_s.OrderDTO_s
{
    public class OrderPutDTO
    {
        [Required]
        public int TotalPrice { get; set; }
        public List<ProductGdedDTO> products { get; set; } = [];
    }
}
