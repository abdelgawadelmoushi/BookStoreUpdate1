using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SolveChallenge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SolveChallenge.Configration
{
    internal class EmployeeEntityTypeConfigtation : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder. HasKey(e => e.Employee_Id);
            builder.Property(e => e.Name)
               .HasMaxLength(256);

            builder.Property(e => e.Salary)
               .HasPrecision(10, 2);
        }
    }
}
