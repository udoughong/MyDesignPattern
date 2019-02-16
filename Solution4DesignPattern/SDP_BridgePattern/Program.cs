using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Platform p = new Windows();
            Image img = new Jpg();
            img.SetPlatform(p);
            img.Init();
            Console.ReadLine();
        }
    }
}
