
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerce522.Data.EntityConfiguration
{
    public class ProductSubImageEntityTypeConfiguration : IEntityTypeConfiguration<ProductSubImage>
    {
        public void Configure(EntityTypeBuilder<ProductSubImage> builder)
        {
            builder.HasKey(e=>new {e.ProductId, e.Img});
        }
    }
}
