using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_TemplateMethodPattern
{
    class Rtf : Document
    {
        protected override void Parse()
        {
            Console.WriteLine("[Rtf] Parse");
        }
        protected override void ReadHeader()
        {
            Console.WriteLine("[Rtf] ReadHeader");
        }
        protected override void Format()
        {
            Console.WriteLine("[Rtf] Format");
        }
        protected override void Display()
        {
            Console.WriteLine("[Rtf] Display");
        }
    }
}
