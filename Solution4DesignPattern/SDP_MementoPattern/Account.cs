using System;

namespace SDP_MementoPattern
{
    public class Account
    {
        double balance;
        public void Deposit(double amount)
        {
            balance += amount;
            ShowBalance();
        }
        public void Withdraw(double amount)
        {
            balance -= amount;
            ShowBalance();
        }
        public Memento GetMemento()
        {
            return new Memento(balance);
        }
        public void SetMemento(Memento m)
        {
            balance = m.GetBalance();
            ShowBalance();
        }

        void ShowBalance()
        {
            Console.WriteLine("Balance is {0}",balance);
        }




    }
}