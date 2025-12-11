using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EFproj.model
{
    internal class Category
    {   
      //  [Key]

       public int? Category_Id { get; set; } 
      //  [Column(TypeName="varchar(256)")]
        public string Name { get; set; } = string.Empty;
        //[MaxLength(256)]
        //[Unicode(false)] // nchar to varchar
        //[Column(Order = 1)]
        public string Description { get; set; }// = string.Empty;//null!; // not Null

     //   [NotMapped]
        public int Status { get; set; }

        public List<Product> Products { get; set; } = [];
    }
}
