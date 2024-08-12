using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class MethodsEg
    {
        static void Main(string[] args)
        {
            int[] myNum = { 22, 12, -12, 2, 21 };
            Console.WriteLine(myNum.Length);
            Console.WriteLine(myNum.Max());
            Console.WriteLine(myNum.Min());
            Console.WriteLine(myNum.Sum());
            Console.WriteLine(myNum.Average());
        } 
    }
}
