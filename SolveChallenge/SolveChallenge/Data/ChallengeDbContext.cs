using Microsoft.EntityFrameworkCore;
using SolveChallenge.Configration;
using SolveChallenge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveChallenge.Data
{
    internal class ChallengeDbContext : DbContext
    {
        public DbSet Employee { get; set; }
        public DbSet Department { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SolveChallenge;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new EmployeeEntityTypeConfigtation().Configure(modelBuilder.Entity<Employee>());
            new DepartmentEntityTypeConfigtation().Configure(modelBuilder.Entity<Department>());

            


        }
    }

    public class DbSet
    {
    }
}
