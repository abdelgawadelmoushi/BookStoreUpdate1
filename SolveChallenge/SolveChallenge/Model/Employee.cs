using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SolveChallenge.Model
{
    internal class Employee
    {
        //[Key]
        public int Employee_Id { get; set; }

        //[Column(TypeName = "nvarchar (256)")]
        public string Name { get; set; }

        //[Column(TypeName = "Decimal (10 , 2)")] // = [Precision (10,2)]

        public decimal Salary { get; set; }
        public int DepartementId { get; set; }
        //[ForeignKey(nameof(DepartementId))]
        public Department department { get; set; }

    }
}
