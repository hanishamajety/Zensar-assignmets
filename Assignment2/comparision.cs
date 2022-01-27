using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class comparision
    {
        static void Main()
        {
            Console.WriteLine("Enter String 1:");
            string wrd1 = Console.ReadLine();
            Console.WriteLine("Enter String 2:");
            string wrd2 = Console.ReadLine();
            char[] a = wrd1.ToLower().ToCharArray();
            char[] b = wrd2.ToLower().ToCharArray();

            Array.Sort(a);
            Array.Sort(b);

            string str1 = new string(a);
            string str2 = new string(b);

            if (str1==str2)
            {
                Console.WriteLine("Given String 1 and String 2 both are same");
            }
            else
            {
                Console.WriteLine("Given String 1 and String 2 are not same");
            }
            Console.ReadLine();
        }
    }
}
