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
    internal class DepartmentEntityTypeConfigtation : IEntityTypeConfiguration<Department>    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.  Property(e => e.Department_Id);
            builder.HasKey(e => e.Department_Id);
            builder.Property(e => e.Name)
                .HasMaxLength(256);

            builder.Property(e => e.Description)
              .IsRequired(false);
        }
    }
}
