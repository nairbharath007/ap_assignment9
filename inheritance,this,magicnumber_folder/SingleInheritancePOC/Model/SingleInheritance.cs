using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInheritancePOC.Model
{

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


}

