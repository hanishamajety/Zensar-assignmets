/*3. Create a simple Stationery application to add items and display added items using Generic collections*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class stationery
    {
        static void Main()
        {
            List<string> l = new List<string>();
            Console.WriteLine("How many items required : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                
                l.Add(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Displaying the required Items: ");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(l[j]);
            }

        }
    }
}


/*OUTPUT:
 * How many items required : 
 * 5                         
 * Paint brush              
 * canvas sheets            
 * pallet                      
 * drawing book                
 * craft book  
 * 
 * Displaying the required Items:    
 * Paint brush                       
 * canvas sheets                    
 * pallet                             
 * drawing book                       
 * craft book                      
 * Press any key to continue . . . 
 
 */
