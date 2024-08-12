using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ForEachEg
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Grapes", "Kiwi", "Guava", "Carrot" };
            foreach (string fruit in fruits)
            {
                Console.Write(fruit+" ");
            }
            Console.WriteLine();
        }
        
    }
}
