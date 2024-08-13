using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Laptop
    {
        string color;
        int cost;
        static void Main(string[] args)
        {
            Console.WriteLine("----------Laptop Details-------------");
            Laptop l1 = new Laptop();
            l1.color = "Grey";
            l1.cost = 45000;
            Console.WriteLine("Color of the first laptop: " + l1.color);
            Console.WriteLine("Cost of the first laptop: " + l1.cost);
            Console.WriteLine();
            Laptop l2 = new Laptop();
            l2.color = "Black";
            l2.cost = 38000;
            Console.WriteLine("Color of the second laptop: " + l2.color);
            Console.WriteLine("Cost of the second laptop: " + l2.cost);

        }
    }
}
