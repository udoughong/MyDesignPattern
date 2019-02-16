using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_StatePattern
{
    class Programmer : User
    {
        public override void View()
        {
            Console.WriteLine("[Programmer] Viewing Data");
        }

        public override void Write()
        {
            Console.WriteLine("[Programmer] Cannot write Data");
        }
    }
}
