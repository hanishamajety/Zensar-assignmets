/* 6. Write a program in C# Sharp to insert the information of two books. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    struct books
    {
        public string title;
        public string author;
    }
    class structbooks
    {
        public static void Main()
        {
            books[] b = new books[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Information of book {i + 1} : ");
                Console.WriteLine("Name of the Book : ");
                b[i].title = Console.ReadLine();
                 

                Console.WriteLine("Name of the Author : "); 
                b[i].author = Console.ReadLine();
                Console.WriteLine();
            }
            
            for (int j=0;j<2;j++)
            {
                Console.WriteLine("Title ={1}, Author={2}",j+1,b[j].title,b[j].author);
                Console.WriteLine();
            }


        }
    }
}


/*OUTPUT:
 *  Information of book 1 :
 *  Name of the Book :  
 *  BASIC            
 *  Name of the Author : 
 *  S.TROELSTRA  
 *  
 *  Information of book 2 : 
 *  Name of the Book :      
 *  C+                      
 *  Name of the Author :    
 *  G.RTRTG      
 *  
 *  Title =BASIC, Author=S.TROELSTRA  
 *  Title =C+, Author=G.RTRTG 
 */
