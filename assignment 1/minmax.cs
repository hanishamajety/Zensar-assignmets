using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class minmax
    {
        public static void Main()
        {
            int a, b, c;

            Console.WriteLine("Enter the value of a,b,c");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("1st number is the largest");
            }
            else if (b > c && b > a)
                Console.WriteLine("2nd number is the largest");
            else
                Console.WriteLine("3rd number is the largest");

            if (a < b && a < c)
            {
                Console.WriteLine("1st number is the Smallest");
            }
            else if (b < c && b < a)
                Console.WriteLine("2nd number is the Smallest");
            else
                Console.WriteLine("3rd number is the Smallest");
            Console.ReadLine();
        }
    }
}


