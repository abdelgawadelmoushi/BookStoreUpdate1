using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyManagementStudio.Models
{
    [PrimaryKey(nameof(CourseId) , nameof(InstructorId))]
    internal class InstructorCourse
    {
        public int CourseId { get; set; }
        public Course Course { get; set; } = default!;
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = default!;

    }
}
