using ProductAppEncapsulation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(1, "Tesla", 1000.0, 20.0);
            Product product2 = new Product(2, "Ford", 75.0, 7.0);

            Console.WriteLine("Product 1 Details:");
            Console.WriteLine(product1.ShowProductDetails());

            Console.WriteLine();

            Console.WriteLine("Product 2 Details:");
            Console.WriteLine(product2.ShowProductDetails());
        }
    }
}
