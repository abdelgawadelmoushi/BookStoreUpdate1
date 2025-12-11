using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFproj.model
{  //  [PrimaryKey("ProductId", ["Img"])] //for many to many relation table  
    [PrimaryKey(nameof(Product_Id), nameof(Img))]
    internal class ProductImg
    {
        public int Product_Id { get; set; }
        public Product Product { get; set; }
        public string Img { get; set; }

    }
}
