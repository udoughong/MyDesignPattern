using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AACAdapter adapter = new AACAdapter();
            PlayAAC(adapter);
            Console.ReadLine();
        }

        static void PlayAAC(Plugin p)
        {
            p.Decode();
        }
    }
}
