using System;

namespace Bank
{
    public class Account
    {
        public List<int> transactions = new List<int>();

        public void Deposit(int ammount)
        {
            if (ammount > 0 && ammount < 100)
            {
                transactions.Add(ammount);
            }
            else{
                Console.WriteLine("Amount of deposit must be greater than 0 and less than 1000");
            } 
        }

        public void Withdraw(int amount)
        {
            if (amount > GetBalance())
            {
                Console.WriteLine("Amount must be less then the balance.");
            }
            else if (amount > 0 && amount <500)
            {
                transactions.Add(-amount);
            }
            else{
                Console.WriteLine("Amount of withdraw must be greater than 0 and less than 500");

            }
        }
    }
}
