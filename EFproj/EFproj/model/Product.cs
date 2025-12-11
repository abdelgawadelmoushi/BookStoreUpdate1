using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFproj.model
{
    [Table("Items",Schema ="Production")] // to change table name

    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }


        public List<Category> category { get; set; } = [];

    }
}
