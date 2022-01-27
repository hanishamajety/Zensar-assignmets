using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class reverse
    {
        public static void Main()
        {
            Console.WriteLine("Enter the String:");
            string rev = Console.ReadLine();
            char[] word =rev.ToCharArray();
            Array.Reverse(word);
            string reverseString = new string(word);
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();
        }

    }
}
