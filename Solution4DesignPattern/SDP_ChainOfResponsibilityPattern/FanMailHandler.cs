using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_ChainOfResponsibilityPattern
{
    class FanMailHandler : MailHandler
    {
        public FanMailHandler(MailHandler handler)
            :base(handler)
        {
        }
        public override void Handle()
        {
            Console.WriteLine("[FanMailHandler] Handle");
            if (nextHandler==null)
            {
                Console.WriteLine("End of chain");
            }
            else
            {
                nextHandler.Handle();
            }
        }
    }
}
