using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppCGPA.Model
{
    internal class Student
    {
        private int rollNo;
        private string name;
        private double cgpa;

        public int RollNo
        {
            get { return rollNo; }
            set { rollNo = ValidateRollNo(value); }
        }

        public string Name
        {
            get { return name; }
            set { name = ValidateName(value); }
        }

        public double CGPA
        {
            get { return cgpa; }
            set { cgpa = ValidateCGPA(value); }
        }

        public double CalculatePercentageFromCGPA()
        {
            return (CGPA / 10) * 100;
        }

        private int ValidateRollNo(int value)
        {
            if (value <= 0)
            {
                Console.WriteLine("Invalid Roll No. Setting to 0.");
                return 0;
            }
            return value;
        }
        private string ValidateName(string value)
        {
            if (value.Length < 5)
            {
                Console.WriteLine("Name should be at least 5 characters. Setting to empty.");
                return string.Empty;
            }
            return value;
        }

        private double ValidateCGPA(double value)
        {
            if (value < 1.0 || value > 10.0)
            {
                Console.WriteLine("CGPA should be between 1.0 and 10.0. Setting to 0.0.");
                return 0.0;
            }
            return value;
        }
    }
}
