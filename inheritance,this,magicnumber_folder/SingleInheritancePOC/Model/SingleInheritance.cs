using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritancePOC.Model
{
    //internal class SingleInheritance
    //{
        class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }

            public void StartEngine()
            {
                Console.WriteLine($"Starting the engine of {Brand} {Model}.");
            }

            public void StopEngine()
            {
                Console.WriteLine($"Stopping the engine of {Brand} {Model}.");
            }
        }

        class Car : Vehicle
        {
            public int NumberOfDoors { get; set; }

            public void Drive()
            {
                Console.WriteLine($"Driving the {Brand} {Model} with {NumberOfDoors} doors.");
            }
        }

        class ElectricCar : Car
        {
            public double BatteryCapacity { get; set; }

            public void ChargeBattery()
            {
                Console.WriteLine($"Charging the battery of {Brand} {Model} with {BatteryCapacity}KWh.");
            }
        }
    }
//}
