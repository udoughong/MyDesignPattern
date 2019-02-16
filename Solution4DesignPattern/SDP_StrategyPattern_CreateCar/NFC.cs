using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_StrategyPattern_CreateCar
{
    class NFC:Protocol
    {
        public override void Transfer()
        {
            Console.WriteLine("[NFC] Transfer");
        }
    }
}
