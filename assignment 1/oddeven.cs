using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class oddeven
    {
        public static void Main()
        {
            int a;
            Console.WriteLine("Enter a number to check odd or even:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
        }
    }
}
