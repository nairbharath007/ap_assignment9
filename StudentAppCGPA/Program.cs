using StudentAppCGPA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppCGPA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            Console.Write("Enter Roll No: ");
            student.RollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter CGPA: ");
            student.CGPA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Student Details:");
            Console.WriteLine($"Roll No: {student.RollNo}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine($"CGPA: {student.CGPA}");
            Console.WriteLine($"Percentage: {student.CalculatePercentageFromCGPA()}%");

        }
    }
}
