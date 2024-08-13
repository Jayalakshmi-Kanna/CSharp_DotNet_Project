using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Cars
    {
        string color = "red";
        //string color;
        //public Cars(string color)
        //{
        //    this.color = color;
        //}
        static void Main(string[] args)
        {
            //Cars car = new Cars("red");
            Cars car = new Cars();
            Console.WriteLine("Color of the car: "+car.color);
        }
    }
}
