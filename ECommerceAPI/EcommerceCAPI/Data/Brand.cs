using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceCAPI.Data.Data
{
    public class Brand : BaseEntity
    {
        public string BrandName { get; set; } = string.Empty;

        [MinLength(5)]
        public string? Description { get; set; }
        [NotMapped]
                public List<Product> Products { get; set; } = new();
          public string MainImg { get; set; } = string.Empty;
        public string ImgPath { get; set; }
    }
}
