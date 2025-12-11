using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFproj.model
{
    internal class Employee
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        // now to add new prop in the table
        public string discreption  { get; set; }
        // i should only add in the package console by adding new migration
    }
}
