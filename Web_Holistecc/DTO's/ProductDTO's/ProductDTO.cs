﻿using System.ComponentModel.DataAnnotations;

namespace Web_Holistecc.DTO_s.ProductDTO_s
{
    public class ProductDTO
    {
        [Required]
        public string ProductName { get; set; }
        [MaxLength(100)]
        public string ProductDescription { get; set; } 
        [Required]
        public int Quantity { get; set; }
    }
}
