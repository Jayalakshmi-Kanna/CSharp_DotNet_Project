using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ConditionalOP
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter your age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //string result = age >= 18 ? "Eligible for voting" : "Not eligible for voting";
            //Console.WriteLine(result);

            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + (num * i));
            }
        }
    }
}
