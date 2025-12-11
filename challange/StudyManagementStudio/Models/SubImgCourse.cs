using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyManagementStudio.Models
{
    internal class SubImgCourse
    {
        public int CourseId { get; set; }
        public Course Course { get; set; } = default!;
        public string Img { get; set;} = string.Empty;

    }
}
