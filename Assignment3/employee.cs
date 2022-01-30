/*5. Write a program in C# Sharp to create a nested structure to store two data for an employee in an array. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class employee
    {
        struct EmployeeDetails
        {
            public string empname;
            public DateofBirth dobirth;

        }
        struct DateofBirth
        {
            public int date;
            public int month;
            public int year;
        }
        public static void Main()
        {
            EmployeeDetails[] ed = new EmployeeDetails[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Name of the employee : ");
                string n = Console.ReadLine();
                ed[i].empname = n;

                Console.WriteLine("Enter the birth date : ");
                int d = Convert.ToInt32(Console.ReadLine());
                ed[i].dobirth.date = d;

                Console.WriteLine("Enter the birth month : ");
                int m = Convert.ToInt32(Console.ReadLine());
                ed[i].dobirth.month = m;

                Console.WriteLine("Enter the birth year : ");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                ed[i].dobirth.year = y;
                

            }
        }
    }

}

/*output
Name of the employee :                                                                                                
hanisha                                                                                                                 
Enter the birth date :                                                                                                 
17                                                                                                                    
Enter the birth month :                                                                                                 
6                                                                                                                       
Enter the birth year :                                                                                                  
1999                                                                                                                                                                                                                                            
Name of the employee :                                                                                                  
nisha                                                                                                                   
Enter the birth date :                                                                                                  
25                                                                                                                     
Enter the birth month :                                                                                                 
12                                                                                                                      
Enter the birth year :                                                                                                  
1999   
*/
