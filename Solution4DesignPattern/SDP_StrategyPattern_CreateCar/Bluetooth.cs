using System;

namespace SDP_StrategyPattern
{
    class Bluetooth:Protocol
    {
        public override void Transfer()
        {
            Console.WriteLine("[Bluetooth] Transfer");
        }
    }
}