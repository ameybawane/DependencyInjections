using System;
/*
 * DIS-ADVANTAGES OF TIGHT COUPLING
 * Tight coupling is when a group of classes are highly dependent on one another.
 * This scenario arises when a class assumes too many responsibilities, or when 
 * one concern is spread over many classes rather than having its own class.
 * Difficult to maintain
 * Difficult to test
 */
namespace TightCoupling
{
    class CurrentAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Current Account.");
        }
    }
    class SavingAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Saving Account.");
        }
    }
    class Account
    {
        CurrentAccount ca = new CurrentAccount();
        SavingAccount sa = new SavingAccount();

        public void PrintAccounts()
        {
            ca.PrintDetails();
            sa.PrintDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.PrintAccounts();

            Console.ReadKey();
        }
    }
}
