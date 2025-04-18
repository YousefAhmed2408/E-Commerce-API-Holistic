using System.ComponentModel.DataAnnotations;

namespace Web_Holistecc.DTO_s.ShoppingCartDTO_s
{
    public class ShoppingCartDTO
    {
        [Required]
        public int NumsOfItems { get; set; }
    }
}
