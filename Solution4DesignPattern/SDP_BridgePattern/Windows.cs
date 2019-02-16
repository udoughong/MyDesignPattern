using System;

namespace SDP_BridgePattern
{
    class Windows:Platform
    {
        public override void Draw()
        {
            Console.WriteLine("[Windows] Draw");
        }
    }
}