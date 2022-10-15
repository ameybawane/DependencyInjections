using System;

namespace ConstructorInjection
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
        private IAccount account;
        public Account(IAccount account) 
            // parameterized constructor
        {
            this.account = account;
        }
        public void PrintAccounts()
        {
            account.PrintDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IAccount ca = new CurrentAccount();
            Account a = new Account(ca);
            a.PrintAccounts();

            IAccount sa = new SavingAccount();
            Account b = new Account(sa);
            b.PrintAccounts();

            Console.ReadKey();
        }
    }
}
