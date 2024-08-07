using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class EqualsOp
    {
        static void Main(string[] args)
        {
            string message1 = "Hello";
            string message2 = "Hello";

            if (message1 == message2)
            {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Different");
            }

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            if (!name.Equals(""))
            {
                Console.WriteLine("Your name is: " + name);
            } else{
                Console.WriteLine("Invalid user input");
            }


            char[] chars = new char[] {'H','e','l','l','o' };
            object newCompare = new string(chars);

            if (message1.Equals(newCompare))
            {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Different");
            }
        }
    }
}
