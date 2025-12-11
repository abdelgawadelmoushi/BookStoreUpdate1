using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTask.Data.EntityConfigurations
{
    public class ProductSubImageEntityTypeConfiguration : IEntityTypeConfiguration<ProductSubImage>
    {
        public void Configure(EntityTypeBuilder<ProductSubImage> builder)
        {
            builder.HasKey(e => new { e.ProductId, e.Img });
        }
    }
}
