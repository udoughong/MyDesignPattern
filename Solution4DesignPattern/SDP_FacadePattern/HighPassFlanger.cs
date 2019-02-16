using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_FacadePattern
{
    public class HighPassFlanger : Flanger
    {
        public override void SetValue()
        {
            Console.WriteLine("[HighPassFlanger] SetValue");
        }
    }
}
