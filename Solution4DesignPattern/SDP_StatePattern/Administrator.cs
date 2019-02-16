using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_StatePattern
{
    class Administrator : User
    {
        public override void View()
        {
            Console.WriteLine("[Administrator] Viewing Data");
        }

        public override void Write()
        {
            Console.WriteLine("[Administrator] Writing Data");
        }
    }
}
