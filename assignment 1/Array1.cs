using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class Array1
    {
        static void Main()
        {
            double sum = 0,avg = 0;
            double max=0,min=9999999;
            Console.Write("enter the size of array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
            {

                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];

                if (numbers[i] > max)                
                    max = numbers[i];
                if (numbers[i] < min)
                    min = numbers[i];
            }
            avg = sum / numbers.Length;
            Console.WriteLine("The Average is : " + avg);
            Console.Write("Maximum element : {0}\n", max);
            Console.Write("Minimum element : {0}\n\n", min);
            
        }        
    }
 }
 
