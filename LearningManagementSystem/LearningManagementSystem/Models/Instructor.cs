using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningManagementSystem.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Address { get; set; }
        public decimal Salary { get; set; }

        public int DepartementId { get; set; }
        public Department Department { get; set; } = default!;

    }
}
