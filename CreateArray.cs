using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class CreateArray
    {
        static void Main(string[] args)
        {
            string[] cars = new string[5];
            cars[0] = "AUDI";
            cars[1] = "BMW";
            cars[2] = "AUDI";
            cars[3] = "SAFARI";
            cars[4] = "JEEP";
            Console.WriteLine(string.Join(", ", cars));
        }
    }
}
