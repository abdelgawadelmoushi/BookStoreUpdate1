using EcommerceCAPI.Data.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ECommerceMAPI.Data.Configrations
{
    internal class CategoryConfigration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CategoryName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(c => c.Description)
                   .HasMaxLength(500);

            // Seed data
            builder.HasData(
                new Category { Id = 1, CategoryName = "Smartphones", MainImg = "iphone15.png", ImgPath = "~/images/product_images", Description = "Mobile phones", Status = true },
                new Category { Id = 2, CategoryName = "Laptops", MainImg = "iphone15.png", ImgPath = "~/images/product_images", Description = "Portable computers", Status = true }
            );
        }
    }
}
