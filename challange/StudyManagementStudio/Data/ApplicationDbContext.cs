using Microsoft.EntityFrameworkCore;
using StudyManagementStudio.Data.Configrations;
using StudyManagementStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyManagementStudio.Data
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Course> courses { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<SubImgCourse> subImgCourses { get; set; }
        public DbSet<InstructorCourse> instructorCourses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SubImgCourseEntityTypeConfigrations).Assembly);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=StudyManagementStudio;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }



    }
}
