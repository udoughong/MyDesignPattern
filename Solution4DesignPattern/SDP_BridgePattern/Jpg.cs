using System;

namespace SDP_BridgePattern
{
    class Jpg:Image
    {
        public override void Init()
        {
            Console.WriteLine("Initializing Jpg image");
            platform.Draw();
        }
    }
}