using System;

namespace SDP_StrategyPattern_CreateCar
{
    class Bluetooth:Protocol
    {
        public override void Transfer()
        {
            Console.WriteLine("[Bluetooth] Transfer");
        }
    }
}