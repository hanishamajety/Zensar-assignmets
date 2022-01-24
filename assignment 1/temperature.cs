using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class temperature
    {
        public static void Main()
        {
            double c = 0;
            double f;
            f =Convert.ToDouble(Console.Read());
            
            c =  (f - 32) * 5 / 9;
            Console.WriteLine("Temperature in celsius: "+c);
            
        }
    }
}
