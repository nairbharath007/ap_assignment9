using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThisKeyword.ThisKey;

namespace ThisKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Alien");
            person1.Introduce(); // Output: Hi, I'm Alien, and I'm 0 years old.

            Person person2 = new Person("Time Traveller", 300);
            person2.Introduce(); // Output: Hi, I'm Time Traveller, and I'm 300 years old.

        }
    }
}
