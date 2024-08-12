using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ParameterEg1
    {
        static void PrintingData(string name, int age)
        {
            Console.WriteLine("Name of the student: " + name);
            Console.WriteLine("Age of the student: " + age);
        }
        static void Main(string[] args)
        {
            PrintingData("Jaya", 22);
            Console.WriteLine();
            PrintingData("Lakshmi", 21);
        }
    }
}
