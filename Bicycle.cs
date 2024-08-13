using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    class Bicycle1
    {
        public string color = "Purple";
        public int cost = 5000;
    }
    internal class Bicycle
    {
        static void Main(string[] args)
        {
            Bicycle1 b1 = new Bicycle1();
            Console.WriteLine("Color of the bicycle: " + b1.color);
            Console.WriteLine("Cost of the bicycle: " + b1.cost);
        }
    }
}
