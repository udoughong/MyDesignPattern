using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_CompositePattern
{
    class Pdf : File
    {
        String version;
        public Pdf(String name, String attributes, String version)
            : base(name, attributes)
        {
            this.version = version;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Name:{0}", name);
            Console.WriteLine("Attributes:{0}", attributes);
            Console.WriteLine("Version:{0}", version);
        }
    }
}
