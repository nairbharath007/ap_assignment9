using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritancePOC.Model
{
    class ElectricCar : Car
    {
        public double BatteryCapacity { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"Charging the battery of {Brand} {Model} with {BatteryCapacity}KWh.");
        }
    }
}
