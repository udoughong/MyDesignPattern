using System;

namespace SDP_StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTransfer dt = new DataTransfer();
            dt.SetProtocol(new Bluetooth());
            dt.LoadStream();
            dt.SendStream();
            dt.SetProtocol(new NFC());
            dt.LoadStream();
            dt.SendStream();
            Console.ReadLine();
        }
    }
}
/*Output:
Loading the stream...
[Bluetooth] Transfer
Loading the stream...
[NFC] Transfer
*/
