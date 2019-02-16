using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_AdapterPattern
{
    class WMAPlugin:Plugin
    {
        public override void Decode()
        {
            Console.WriteLine("[WMAPlugin] Decode");
        }
    }
}
