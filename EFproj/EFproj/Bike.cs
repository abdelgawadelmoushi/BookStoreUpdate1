using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFproj
{
    internal class Bike : Viehcle
    {
        public int hasGear  { get; set; }
        public override string DisplayInfo()
        {
            return $"model is {Model} price per day is : {PricePerDay} and has Gear is {hasGear}";
        }
        public override string ToString()
        {
            return $"id is {Id} model is {Model} price per day is : {PricePerDay} and fuel type is {hasGear}";

        }
    }

}
