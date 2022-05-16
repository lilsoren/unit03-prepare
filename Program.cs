using System;

namespace Cse210Starter
{
    class Program
    {
        static void Main(string[] args)
        {
            Account accoint1 = new Account();

            account1.Deposit(50);

            account1.Deposit(100);
            account1.Withdraw(100);

            Console.WriteLine($"{account1.GetBalance()}")
        }
    }
}
