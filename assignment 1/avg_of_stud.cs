using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_1
{
    class avg_of_stud
    {
        static void Main()
        {
            int rl = 0, total;
            double per;
            int i;
            float avg_1 = 0, avg_2 = 0, avg_3 = 0;

            Console.Write("Number of students :");
            rl = Convert.ToInt32(Console.ReadLine());


            int[] C_Sharp = new int[rl];
            int[] HTML = new int[rl];
            int[] Sql = new int[rl];
            for (i = 0; i < rl; i++)
            {
                Console.WriteLine("Enter the marks of " + i + " student");
                C_Sharp[i] = Convert.ToInt32(Console.ReadLine());
                HTML[i] = Convert.ToInt32(Console.ReadLine());
                Sql[i] = Convert.ToInt32(Console.ReadLine());


            }
            for (i = 0; i < rl; i++)
            {
                per = 0;
                total = C_Sharp[i] + HTML[i] + Sql[i];
                per = total / 3.0;
                if (per < 50)
                    Console.WriteLine("pass");
                else
                    Console.WriteLine("fail");



            }

        }
    }
}
