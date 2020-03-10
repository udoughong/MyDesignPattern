using System;

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
/*Output:
Balance is 1000
Saving state of account...
Balance is 6000
Saving state of account...
Balance is 2000
Restoring state...
Balance is 6000
Balance is 1000
*/
