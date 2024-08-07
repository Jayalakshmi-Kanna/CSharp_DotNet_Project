using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class PrintingData
    {
       static void Main(string[] args)
        {
            string name = "Jayalakshmi";
            int age = 22;

            Console.WriteLine("Name: "+name);
            Console.WriteLine("Age: "+ age);

            Console.WriteLine();

            Console.WriteLine("Name: " + name + "\nage: " + age);
            Console.WriteLine("You name is " + name + " amd your age is " +age);

            Console.WriteLine("Your name is {0} and your age is {1}", name, age);
            Console.WriteLine("Name: {0} \nage: {1}", name, age);

            Console.WriteLine($"Your name is {name} and your age is {age}");

            string test = string.Concat("Your name is ", name, " and your age is ", age);
            Console.WriteLine(test);

            string[] names = new string[] { "Kanna ", "Jaya ", "Lakshmi " };
            Console.WriteLine(string.Concat(names));
        }
    }
}
