using Company.Models;
using Microsoft.EntityFrameworkCore;

namespace Company
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Data Source=.;Initial Catalog=CompanyDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Employee config
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.Employee_Id);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Name)
                .HasColumnType("nvarchar(256)")
                .IsRequired();

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasColumnType("decimal(10,2)");

            // Department config
            modelBuilder.Entity<Department>()
                .HasKey(d => d.Department_Id);

            modelBuilder.Entity<Department>()
                .Property(d => d.Name)
                .HasColumnType("nvarchar(256)")
                .IsRequired();

            modelBuilder.Entity<Department>()
                .Property(d => d.Description)
                .HasColumnType("nvarchar(max)")
                .IsRequired(false);

            // Relationship: One Department → Many Employees
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.Department_Id);
        }
    }
}
