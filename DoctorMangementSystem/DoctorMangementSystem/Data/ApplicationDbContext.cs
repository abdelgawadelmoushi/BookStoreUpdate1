using adminMangementSystem.Models;
using DoctorMangementSystemTask.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorMangementSystemTask.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DoctorMangementSystemTask;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasKey(a => a.Id);

                entity.ToTable("Appointments");

                entity.Property(a => a.PatientName)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(a => a.Email)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(a => a.Phone)
                      .IsRequired()
                      .HasMaxLength(20);

                entity.Property(a => a.Department)
                      .HasMaxLength(100);

                entity.Property(a => a.Date)
                      .IsRequired();

                entity.Property(a => a.Time)
                      .IsRequired();

                entity.Property(a => a.Notes)
                      .HasMaxLength(500);
            });
        }
    }

   }

