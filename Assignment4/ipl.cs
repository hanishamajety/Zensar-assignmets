/*1. Write a program to find the Sum and the Average points scored by the teams in the IPL. Create a Class called Cricket that has a function called
 * Pointscalculation(int no_of_matches)that takes no.of matches as input and accepts that many scores from the user. The function should then display 
 * the Average and Sum of the scores*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Assignment4
{
    class Cricket
    {
        int[] matches;
        double sum=0;
        double average=0;
        public void Pointscaluclation(int No_of_Matches)
        {
            matches = new int[No_of_Matches];           
            for (int i=0;i<No_of_Matches;i++)
            {
                Console.WriteLine("Enter the score achieved in match{0}", i + 1);
                matches[i]=int.Parse(Console.ReadLine());
            }

            for( int i=0;i<matches.Length;i++)
            {
                sum = sum+ matches[i];
            }
            Console.WriteLine("The sum of the score is : "+sum);            
            average = sum / matches.Length;
            Console.WriteLine("Average obtained from the above scores : "+ matches.Length);
        }

    }
    class ipl
    {
        static void Main(string[] args)
        {
            Cricket c = new Cricket();
            Console.WriteLine("Enter the no.matches completed : ");
            int nom=Convert.ToInt32( Console.ReadLine());
            c.Pointscaluclation(nom);
            Console.Read();
        }
    }
}

/*OUTPUT:
 * Enter the no.matches completed : 
 * 5                                 
 * Enter the score achieved in match1   
 * 234                                  
 * Enter the score achieved in match2   
 * 286                                  
 * Enter the score achieved in match3    
 * 190                                   
 * Enter the score achieved in match4    
 * 156                                   
 * Enter the score achieved in match5                                 
 * 320                                                                                                                    
 * The sum of the score is : 1186               
 * Average obtained from the above scores : 5   */
