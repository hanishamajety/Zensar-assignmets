using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Account
    {
        public int AccountNo;
        public string Customername;
        public string Accounttype;
        public double balance = 100000, w, d;
        


        public void AccountDetails()
        {
            Console.WriteLine("Account details of customer:");
            Console.WriteLine("Account Number:");
            AccountNo =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customer name:");
            Customername = Console.ReadLine();
            Console.WriteLine("Account Type : Savings");
            Console.WriteLine("Initial balance" + balance);
        }

        
        public void Transactiontype()
        {     
            Console.WriteLine("Enter your transaction type:(w/d)");
            var typeoftransaction = Convert.ToChar( Console.ReadLine());
            if (typeoftransaction == 'D' || typeoftransaction == 'd')
            {

                Console.WriteLine($"Enter the amount the you want to deposit: ");
                d = Convert.ToDouble(Console.ReadLine());
                balance = d + balance;
                Console.WriteLine("Your Account balance is"+ balance);
                
            }
            else
            {
                Console.WriteLine($"Enter the amount the you want to withdraw: ");
                w = Convert.ToDouble(Console.ReadLine());
                balance -= w;
                Console.WriteLine("Your Account balance is" + balance);
            }
            
        }
    }
    
    class bank
    {
        static void Main()
        {

            Account account = new Account();
            
            account.AccountDetails();

            account.Transactiontype();

        }
    }
}
