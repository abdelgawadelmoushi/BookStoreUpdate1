using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFproj
{
    internal class Car : Viehcle
    {
        public string FuelType { get; set; }
        public override string DisplayInfo()
        {
            return $"model is {Model} price per day is : {PricePerDay} and fuel type is {FuelType}";
        }
        public override string ToString()
        {
            return $"id is {Id} model is {Model} price per day is : {PricePerDay} and fuel type is {FuelType}";

        }
    }
}
