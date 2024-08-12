using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ParametersEg
    {
        static void PrintName(string name)    //parameter
        {
            Console.WriteLine("Name of the programmer: " + name);
        }
        static void Main(string[] args)
        {
            PrintName("Jayalakshmi");        //argument
        }
    }
}
