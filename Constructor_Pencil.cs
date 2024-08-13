using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class Constructor_Pencil
    {
        //Declare a variable/field
        public string brand;

        //Create a contructor

        public Constructor_Pencil()
        {
            brand = "Nataraj";           //Initialize the variable/field
        }
        
        //Create a main method
        static void Main(string[] args)
        {
            //Create an object
            Constructor_Pencil con = new Constructor_Pencil();

            //Print the result
            Console.WriteLine(con.brand);
        }
    }
}
