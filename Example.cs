using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Example
    {
        static void Main(string[] args)
        {
            //for(int i = 1; i <= 5; i++)
            //   {
            //       Console.WriteLine(i);
            //   }

            //for (int i=1;i<=20;i+=2)
            //{
            //    Console.WriteLine(i);
            //}
            Console.Write("Enter the message you want to repeat: ");
            string message = Console.ReadLine();
            Console.Write("Enter how many time you want to print the Hi?: ");
            int loopcounter = Convert.ToInt32(Console.ReadLine());
            if (loopcounter <=0 )
            {
                Console.WriteLine("Sorry please enter a number greater than 0");
            }
            else
            {
                for (int i = 0; i < loopcounter; i++)
                {
                    //Console.WriteLine("HI");
                    Console.WriteLine(message);
                }
            }
        }
    }
}
