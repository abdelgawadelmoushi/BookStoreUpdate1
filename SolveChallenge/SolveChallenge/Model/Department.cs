using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveChallenge.Model
{
    internal class Department
    {
        public int  Department_Id { get;  set; }

        //[Column(TypeName = "nvarchar (256)")]

        public string Name { get; set; }
        public string? Description { get; set; }
            

    }
}
