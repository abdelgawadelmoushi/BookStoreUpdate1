using LearningManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Data.Configrations
{
    internal class InstructorCourseEntityTypeConfigrations : IEntityTypeConfiguration<InstructorCourse>
    {
        public void Configure(EntityTypeBuilder<InstructorCourse> builder)
        {

            builder.HasKey(i => new
            {
                i.CourseId,
                i.InstructorId,
            });
           
        }
    }
}
