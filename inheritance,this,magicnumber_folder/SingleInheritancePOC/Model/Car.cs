using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritancePOC.Model
{
     class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public void Drive()
        {
            Console.WriteLine($"Driving the {Brand} {Model} with {NumberOfDoors} doors.");
        }
    }
}
