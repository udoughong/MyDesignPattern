using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_IteratorPattern
{
    public abstract class Collection
    {
        public abstract Iterator CreateIterator();
        public abstract void Add(int val);
        public abstract int GetLength();
    }
}
