using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_FacadePattern
{
    class TwoPassEqualizer : Equalizer
    {
        public override void SetHigh()
        {
            Console.WriteLine("[TwoPassEqualizer] SetHigh");
        }

        public override void SetMid()
        {
            Console.WriteLine("[TwoPassEqualizer] SetMid");
        }

        public override void SetLow()
        {
            Console.WriteLine("[TwoPassEqualizer] SetLow");
        }
    }
}
