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
            Console.WriteLine("HI");
        }
        static void PrintData()
        {
            Console.WriteLine("Hello");
        }
        static void Main(string[] args)
        {
            PrintData();
        }
    }
}
