using System;

namespace calcutateconcession
{
    public class Class1
    {
        int age,price;
        
        double totalfare=500;
        
        public void Eligible()
        {
            if(age<=5)
            {
                Console.WriteLine("Little Champs-Free Ticket");
            }
            else if(age>60)
            {
                double dis = totalfare*0.3;
                double fare=totalfare-dis;
                Console.WriteLine("Senior  citizen : {0}", fare);
            }
            else
            {
                Console.WriteLine("Each Ticket costs : ", + totalfare);
            }
            
        }
    }
}
