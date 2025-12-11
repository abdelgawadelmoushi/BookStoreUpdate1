using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaTask.Data.EntityConfigurations
{
    public class ProductColorEntityTypeConfiguration : IEntityTypeConfiguration<ProductColor>
    {
        public void Configure(EntityTypeBuilder<ProductColor> builder)
        {
            builder.HasKey(e => new { e.ProductId, e.Color });
        }
    }
}
