using System;
using System.Collections.Generic;
using System.Text;

namespace EcommerceCAPI.Data.DTOs
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public string MainImg { get; set; } = string.Empty;
        public string ImgPath { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public int Quantity { get; set; }

    }
}
