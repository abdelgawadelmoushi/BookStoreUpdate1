using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFproj
{



    public abstract class  Viehcle
    {
        public int Id { get; set; }
        public int Model { get; set; }
        public double PricePerDay { get; set; }

        public abstract string DisplayInfo();

        public double CalculateDays(int days) {
            double x = 0;
            if (days>0)
            {
                x=days * PricePerDay;
            }
            return x;
           }

    }

}
