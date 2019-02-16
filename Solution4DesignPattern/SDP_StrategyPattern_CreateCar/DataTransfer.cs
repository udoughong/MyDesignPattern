using System;

namespace SDP_StrategyPattern_CreateCar
{
    class DataTransfer
    {
        private Protocol protocol;
        internal void SetProtocol(Protocol p)
        {
            protocol = p;
        }

        internal void SendStream()
        {
            if (protocol != null)
            {
                protocol.Transfer();
            }
        }

        internal void LoadStream()
        {
            Console.WriteLine("Loading the stream...");
        }
    }
}