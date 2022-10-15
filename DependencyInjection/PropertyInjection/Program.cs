using System;

namespace PropertyInjection
{
    public interface IAccount
    {
        void PrintDetails();
    }
    class CurrentAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Current Account.");
        }
    }
    class SavingAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("Details of Saving Account.");
        }
    }
    class Account
    {
        public IAccount account { get; set; }
        public void PrintAccounts()
        {
            account.PrintDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account ca = new Account();
            ca.account = new CurrentAccount();
            ca.PrintAccounts();

            Account sa = new Account();
            sa.account = new SavingAccount();
            sa.PrintAccounts();

            Console.ReadKey();
        }
    }
}
