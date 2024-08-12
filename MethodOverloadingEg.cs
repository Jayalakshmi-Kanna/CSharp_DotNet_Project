using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class MethodOverloadingEg
    {
        static void MyMethod(int x,int y)
        {
            int z = x + y;
            Console.WriteLine(z);
        }
        static void MyMethod(double x, double y)
        {
            double z = x + y;
            Console.WriteLine(z);
        }
        static void Main(string[] args)
        {
            MyMethod(23, 2);
        }
    }
}
