using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_BridgePattern
{
    class Mac : Platform
    {
        public override void Draw()
        {
            Console.WriteLine("[Mac] Draw");
        }
    }
}
