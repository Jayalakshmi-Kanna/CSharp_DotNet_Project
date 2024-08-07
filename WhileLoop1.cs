using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class WhileLoop1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int answer = num1 * num2;
            int actualAns = 0;

            Console.Write("What the value of " + num1 + "*" + num2 + " is? ");
            Console.WriteLine();

            while (answer != actualAns)
            {
                Console.Write("Enter your answer: ");
                actualAns = Convert.ToInt32(Console.ReadLine());

                if (answer != actualAns)
                {
                    Console.WriteLine("Your answer was not correct");
                }
            }
            Console.WriteLine("Your answer was correct");
        }
    }
}
