using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword.ThisKey
{
    internal class Person
    {
        private string name;
        private int age;

        public Person(string name)  // Disambiguity b/w constructor parameter and instance variable
        {
            this.name = name;
            this.age = 0; // Default age
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age; // Set age using the chained constructor
        }

        public void Introduce() //accessing fields
        {
            Console.WriteLine($"Hi, I'm {this.name}, and I'm {this.age} years old.");
        }
    }
}
