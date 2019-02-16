using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account();
            CareTaker c = new CareTaker();
            acc.Deposit(1000);
            Console.WriteLine("Saving state of account...");
            c.SaveMemento(acc.GetMemento());
            acc.Deposit(5000);
            Console.WriteLine("Saving state of account...");
            c.SaveMemento(acc.GetMemento());
            acc.Withdraw(4000);
            Console.WriteLine("Restoring state...");
            acc.SetMemento(c.RestoreMemento());
            acc.SetMemento(c.RestoreMemento());
            Console.ReadLine();
        }
    }
}
