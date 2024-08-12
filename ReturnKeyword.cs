using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ReturnKeyword
    {
        static int Addition(int x)
        {
            return x + 1;
        }
        static string Concatenation(string s)
        {
            return s + " Lakshmi";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Addition(4));
            Console.WriteLine(Concatenation("Jaya"));
        }
    }
}
