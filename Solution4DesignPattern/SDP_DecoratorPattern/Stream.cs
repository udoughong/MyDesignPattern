using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_DecoratorPattern
{
    public abstract class Stream
    {
        public abstract void Write();
        public abstract void Read();
    }
}
