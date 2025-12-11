using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description  { get; set; }
        public string MainImg  { get; set; } = string.Empty;
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; } = default!;

        public int CourseId { get; set; }

    }
}
