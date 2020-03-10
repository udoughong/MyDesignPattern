using System;

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
/*Output:
Initializing Jpg image
[Windows] Draw
*/
