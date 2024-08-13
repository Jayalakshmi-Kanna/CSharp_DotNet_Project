using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class MethodOverloadingEg1
    {
        static void PrintData(string s)
        {
            Console.WriteLine("This method contains parameters");
            Console.WriteLine("Name of the student: " + s);
        }
        static void PrintData()
        {
            Console.WriteLine("This method contains without parameters");
        }
        static void Main(string[] args)
        {
            PrintData();
            Console.WriteLine();
            PrintData("Jayalakshmi");
        }
    }
}
