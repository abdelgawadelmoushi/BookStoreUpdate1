using EcommerceCAPI.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceMAPI.Data.Configrations
{
    internal class BrandConfigration : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey(b => b.Id);

            builder.Property(b => b.BrandName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(b => b.Description)
                   .HasMaxLength(500);

            // Seed data
            builder.HasData(
                new Brand { Id = 1, BrandName = "Apple", MainImg = "iphone15.png", ImgPath = "~/images/product_images", Description = "Smart", Status = true },
                new Brand { Id = 2, BrandName = "Samsung", MainImg = "iphone15.png", ImgPath = "~/images/product_images", Description = "Smart", Status = true }
            );
        }
    }
}
