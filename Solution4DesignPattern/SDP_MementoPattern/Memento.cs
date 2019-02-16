using System;

namespace SDP_MementoPattern
{
    public class Memento
    {
        private double balance;

        public Memento(double amount)
        {
            balance = amount;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}