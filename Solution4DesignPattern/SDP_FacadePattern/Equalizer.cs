using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_FacadePattern
{
    public abstract class Equalizer
    {
        public abstract void SetHigh();
        public abstract void SetMid();
        public abstract void SetLow();
    }
}
