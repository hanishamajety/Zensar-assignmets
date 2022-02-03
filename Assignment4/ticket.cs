using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Assignment4
{
    class ticket
    {
        public static void Main()
        {

            Class1 c = new Class1();
            
            Console.WriteLine("Enter the Name: ");
            string name = Console.ReadLine();
            c.Eligible();
            Console.Read();

        }
    }
}

