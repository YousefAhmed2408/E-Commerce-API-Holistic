using System.ComponentModel.DataAnnotations;

namespace Web_Holistecc.DTO_s.OrderDTO_s
{
    public class OrderDTO
    {
        [Required]
        public int TotalPrice { get; set; }
    }
}
