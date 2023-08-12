using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicNumberCleanCode.Model;

namespace MagicNumberCleanCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();

            Console.WriteLine($"Initial state: {trafficLight.GetCurrentState()}");

            trafficLight.ChangeState();
            Console.WriteLine($"Changed state: {trafficLight.GetCurrentState()}");

            trafficLight.ChangeState();
            Console.WriteLine($"Changed state: {trafficLight.GetCurrentState()}");

            trafficLight.ChangeState();
            Console.WriteLine($"Changed state: {trafficLight.GetCurrentState()}");
        }
    }
}
