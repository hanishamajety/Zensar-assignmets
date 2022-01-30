/*2. Write a class called LoanProcess with Loan_No, Customer Name, LoanAmount, EMI_Amount,
 * Account_Balance as its members. Create a method calculate_EMI() for the LoanAmount , 
 * with the rate of interest as 13% for a total of 3 years and store it in the EMI_Amount.
 * The rest of the information to be passed through constructors. Write another function 
 * CheckBalance() which checks if the Account_Balance is less than the EMI_AMount. If yes
 * then throw a custom exception. Display " Not Sufficient Balance to repay Loan" in the 
 * finally. Give explanatory comments.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class BalanceException : ApplicationException
    {
        public BalanceException(string msg) : base(msg)
        {
        }
    }
    class loandetails
    {
        public int Loan_id;
        public string custname;
        float LoanAmt;
        double AccBalance;
        double Emi_amount;

        public loandetails()
        {
            Console.WriteLine("Enter the name: " );
            custname = Console.ReadLine();

            Console.WriteLine("Enter the Loan ID: ");
            Loan_id =Convert.ToInt32( Console.ReadLine());
        }
        public  void calculate_EMI()
        {
            
            Console.WriteLine("Enter the loan amount: ");
            LoanAmt = float.Parse(Console.ReadLine());
            Emi_amount = (LoanAmt * 13 * 3) / 100;
            Console.WriteLine("Emi Amount to be paid : "+Emi_amount);
        }

        public void CheckBalance()
        {
            Console.WriteLine("Enter the Account Balance: ");
            AccBalance = float.Parse(Console.ReadLine());

            if (AccBalance < Emi_amount)
                throw (new BalanceException("Not sufficient Balance to repay Loan"));
            else
                Console.WriteLine("EMI amount debited from your account....");

        }
    }
    class loan
    {
        public static void Main(string[] args)
        {
            loandetails l = new loandetails();
            Console.WriteLine("Account Name: " + l.custname);
            Console.WriteLine("Loan details: " + l.Loan_id);
            Console.WriteLine();
            l.calculate_EMI();
            try
            {
                l.CheckBalance();
            }
            catch(BalanceException be)
            {
                Console.WriteLine(be.Message);
            }
        }
        
    }
}

/*OUTPUT:
 * Enter the name:                                                                                                         
 * Hanisha                                                                                                                  
 * Enter the Loan ID:                                                                                                      
 * 32845691                                                                                                                    
 * Account Name: Hanisha                                                                                                        
 * Loan details:32845691 
 * 
 * Enter the loan amount:                                                                                                  
 * 23456                                                                                                                   
 * Emi Amount to be paid : 9147.84                                                                                         
 * Enter the Account Balance:                                                                                              
 * 5000                                                                                                                   
 * Not sufficient Balance to repay Loan      
 * Press any key to continue . . .   
 * 
 * 
 * 
 * Enter the name:            
 * Nisha                      
 * Enter the Loan ID:         
 * 2313485                    
 * Account Name: Nisha        
 * Loan details: 2313485 
 * 
 * Enter the loan amount:    
 * 1258.52                   
 * Emi Amount to be paid : 490.822807617187  
 * Enter the Account Balance:              
 * 5000                                  
 * EMI amount debited from your account....  
 * 
 * Press any key to continue . . .     
 */