using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudyManagementStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyManagementStudio.Data.Configrations
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
