using System;
using aula135Heranca.Entities;

namespace aula135Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            acc1.WithDraw(10.0);
            acc2.WithDraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

            //Account account = new Account(1001, "Alex", 0.0);
            //BusinessAccount bAccount = new BusinessAccount(1002, "Maria", 0.0, 500.0);
            //
            //// UPCASTING
            
            //Account acc1 = bAccount;
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);
            //
            //// DOWNCASTING
            
            //BusinessAccount acc4 = (BusinessAccount)acc2;
            //acc4.Loan(100.0);
            //
            //if(acc3 is BusinessAccount)
            //{
            //   BusinessAccount acc5 = acc3 as BusinessAccount;
            //    acc5.Loan(200.0);
            //    Console.WriteLine("Loan!");
            //}
            //
            //if(acc3 is SavingsAccount)
            //{
            //    SavingsAccount acc5 = acc3 as SavingsAccount;
            //    acc5.UpdateBalance();
            //    Console.WriteLine("Update!");
            //}
        }
    }
}
