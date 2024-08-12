using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class StringRev
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your message: ");
            string name = Console.ReadLine();
            Console.WriteLine("Name: "+name);

            for (int i =name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine();
        }
    }
}
