using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFproj.model
{
    //  [PrimaryKey("ProductId", ["Img"])] //for many to many relation table  
    [PrimaryKey(nameof(Product_Id),nameof(UserId))]
    internal class UserProduct
    {
        public int Product_Id { get; set; }
        public User user { get; set; }
        public string UserId { get; set; }
        public Product product { get; set; }
    }
}
