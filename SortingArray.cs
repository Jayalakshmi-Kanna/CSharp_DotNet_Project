using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class SortingArray
    {
        static void Main(string[] args)
        {
            int[] myNum = { 22, 12, -12, 2, 21 };
            Array.Sort(myNum);
            foreach (int i in myNum)
            {
                Console.WriteLine(i);
            }
        }
    }
}
