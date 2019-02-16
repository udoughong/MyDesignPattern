using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_StatePattern
{
    class Guest : User
    {
        public override void View()
        {
            Console.WriteLine("[Guest] Cannot view Data");
        }

        public override void Write()
        {
            Console.WriteLine("[Guest] Cannot write Data");
        }
    }
}
