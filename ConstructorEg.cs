using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ConstructorEg
    {
        public string color;

        public ConstructorEg(string colorName)
        {
            color = colorName;
        }
        static void Main(string[] args)
        {
            ConstructorEg con = new ConstructorEg("Red");
            Console.WriteLine(con.color);
        }
    }
}
