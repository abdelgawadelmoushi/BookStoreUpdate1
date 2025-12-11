using EFproj.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFproj
{
    internal class ApplicationDbcontext : DbContext
    {
        // prop for the table to be created , name of the class <Employee>  name of the table Employees
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> categories { get; set; }
      

        public DbSet<User> Users { get; set; }

    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // to creat new database 
            // now we can see the name of the data base created as well as the table 
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EFProj522;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>()
              //  .HasKey(e=>e.Category_Id) ;
              .HasKey(nameof(Category.Category_Id));

            modelBuilder.Entity<Category>()
                .Property(e => e.Name) // has function => function.Name
                .HasColumnType("Varchar(256)");

            modelBuilder.Entity<Product>()
                .ToTable("Items", "Production");


            modelBuilder.Entity<User>()
                .OwnsOne(e => e.Address);

            modelBuilder.Entity<ProductImg>()
             //  .HasKey(e=>e.Category_Id) ;
             .HasKey(nameof(ProductImg.Product_Id),nameof(ProductImg.Img));

            //func <1-16 , return>
            //


        }



    }
}
