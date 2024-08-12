using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class DefaultParameter
    {
        static void defaultParameter(string name,int age,string country = "India")
        {
            Console.WriteLine("Name of the student: " + name);
            Console.WriteLine("Age of the student: " + age);
            Console.WriteLine("Country of the student: " + country);
        }
        static void Main(string[] args)
        {
            defaultParameter("Jaya", 22);
            Console.WriteLine();
            defaultParameter("Lakshmi", 21);

            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

        }
    }
}
