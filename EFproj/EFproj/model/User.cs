using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFproj.model
{
    internal class User
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    //    public Address Address { get; set; }
       

    }
   // [Owned] // to call class with details as below as property

    internal class Address

    {

        public string City { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
    }
}
