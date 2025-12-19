using EcommerceCAPI.Data.Data;
using ECommerceMAPI.Data.Configrations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.Extensions.Configuration;

namespace ECommerceMAPI.Data.Data
{
    public class ECommerceMAPIDbContext : IdentityDbContext<FirstMinimalAPI.Models.ApplicationUser>
    {


        public ECommerceMAPIDbContext(DbContextOptions<ECommerceMAPIDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ProductConfigration());
            builder.ApplyConfiguration(new BrandConfigration());
            builder.ApplyConfiguration(new CategoryConfigration());


        }

    }


    public class ECommerceMAPIDbContextFactory : IDesignTimeDbContextFactory<ECommerceMAPIDbContext>
    {
        public ECommerceMAPIDbContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(AppContext.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ECommerceMAPIDbContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(
                connectionString,
                b => b.MigrationsAssembly("ECommerceAPI") 
            );

            return new ECommerceMAPIDbContext(optionsBuilder.Options);
        }
    }

}
