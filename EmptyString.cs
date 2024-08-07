using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class EmptyString
    {
        static void Main(string[] args)
        {
            Console.Write("your name is: ");
            string name = Console.ReadLine();

            if (name != string.Empty)         // if (name != "")
            {
                Console.WriteLine($"Your name is {name}");
            } else
            {
                Console.WriteLine("Name is empty");
            }
        }
    }
}
