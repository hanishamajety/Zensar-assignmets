using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {

        int age, price;

        double totalfare = 500;

        public void Eligible()
        {
            Console.WriteLine("Enter the age: ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age <= 5)
            {
                Console.WriteLine("Little Champs-Free Ticket");
            }
            else if (age > 60)
            {
                double dis = totalfare * 0.3;
                double fare = totalfare - dis;
                Console.WriteLine("Senior  citizen : {0}", fare);
            }
            else
            {
                Console.WriteLine("Each Ticket costs : " +totalfare);
            }

        }
    }
}
