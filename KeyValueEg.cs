using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class KeyValueEg
    {
        static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child name is: " + child3);
        }
        static void Main(string[] args)
        {
            MyMethod(child1: "Jayalakshmi", child2: "Hari", child3: "Krishna");
        }
    }
}
