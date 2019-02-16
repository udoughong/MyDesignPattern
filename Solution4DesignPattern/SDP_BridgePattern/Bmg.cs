using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_BridgePattern
{
    class Bmg : Image
    {
        public override void Init()
        {
            Console.WriteLine("Initializing Bmp image");
            platform.Draw();
        }
    }
}
