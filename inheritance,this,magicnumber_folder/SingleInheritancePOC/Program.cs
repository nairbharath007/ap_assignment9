using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingleInheritancePOC.Model;

namespace SingleInheritancePOC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectricCar teslaModelS = new ElectricCar
            {
                Brand = "Tesla",
                Model = "Model S",
                NumberOfDoors = 4,
                BatteryCapacity = 75.0
            };

            Console.WriteLine($"Vehicle Details: {teslaModelS.Brand} {teslaModelS.Model}");
            teslaModelS.StartEngine();
            teslaModelS.Drive();
            teslaModelS.ChargeBattery();
            teslaModelS.StopEngine();
        }
    }
}

