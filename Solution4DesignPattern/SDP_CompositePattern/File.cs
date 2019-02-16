using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_CompositePattern
{
    public abstract class File
    {
        protected String name;
        protected String attributes;
        public File(String name, String attributes)
        {
            this.name = name;
            this.attributes = attributes;
        }
        public abstract void DisplayInfo();
    }
}
