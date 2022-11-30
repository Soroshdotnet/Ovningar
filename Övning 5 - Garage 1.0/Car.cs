using Övning_5_Garage_1._0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_5___Garage_1._0
{
    internal class Car : Vehicle
    {
        public string Brand { get; set; }
        public Car(string regnr, string brand) : base(regnr)
        {
            Console.WriteLine("Ange brand");
            Brand = Console.ReadLine();
        }

        public override string VehicleInfo()
        {
            return $"{base.VehicleInfo()}Brand: {Brand}.";
        }
    }
}
