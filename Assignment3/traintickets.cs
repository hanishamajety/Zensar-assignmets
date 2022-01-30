/*1. Create a console application to book train tickets. Create a Passanger 
 class with (Name, Age) and write a function called TicketBooking(no_of_tickets) 
 that takes no.of tickets to be booked. If the no of tickets is > 5 per booking,
 raise an user defined exception,and print "cannot book more than 2 tickets". 
 Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking
 method by accepting all required details.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class booking:ApplicationException
    {
        public booking(string msg): base(msg)
        { }
    }
    class Passanger
    {
        string name;
        int age;
        public void PassangerDetails()
        {
            Console.WriteLine("Enter the Name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter the Age: ");
            age =Convert.ToInt32( Console.ReadLine());
        }
        public void TicketBooking(int no_of_tickets)
        {
            if(no_of_tickets>5)
            {
                throw (new booking("cannot book more than 2 tickets"));
            }
            else
            {
                Console.WriteLine("Ticket Booking Successfull");
            }
        }

    }
    class traintickets
    {
        static void Main()
        {
            Passanger p = new Passanger();
            p.PassangerDetails();
            Console.WriteLine("Enter the number of tickets required");
            int n = Convert.ToInt32(Console.ReadLine());
            try
            {
                p.TicketBooking(n);
            }
            catch(booking b)
            {
                Console.WriteLine(b.Message+" "+b.Source);
            }
            

        }
    }
}


/*
OUTPUT:
Enter the Name:               
hanisha                                                                                                                 
Enter the Age:                                                                                                          
22                                                                                                                      
Enter the number of tickets required                                                                                    
6                                                                                                                      
cannot book more than 2 tickets 

Enter the Name:                                                                                                         
nisha                                                                                                                   
Enter the Age:                                                                                                          
23                                                                                                                      
Enter the number of tickets required                                                                                    
4                                                                                                                       
Ticket Booking Successfull                                                                                              
Press any key to continue . . .  
 
 */
