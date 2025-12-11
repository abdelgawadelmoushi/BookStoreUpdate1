using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using LearningManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Data.Configrations
{
    internal class SubImgCourseEntityTypeConfigrations : IEntityTypeConfiguration<SubImgCourse>
    {
        public void Configure(EntityTypeBuilder<SubImgCourse> builder)
        {

            builder.HasKey(c => new
                 {
                     c.CourseId,
                     c.Img,
                 });
        }


   
    }


}
