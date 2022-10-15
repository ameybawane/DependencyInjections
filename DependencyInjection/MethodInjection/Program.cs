using System;

namespace MethodInjection
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
        public void PrintAccounts(IAccount account)
        {
            account.PrintDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account ca = new Account();
            ca.PrintAccounts(new CurrentAccount());

            Account sa = new Account();
            sa.PrintAccounts(new SavingAccount());

            Console.ReadKey();
        }
    }
}
