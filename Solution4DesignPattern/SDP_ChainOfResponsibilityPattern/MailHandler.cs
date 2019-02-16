using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_ChainOfResponsibilityPattern
{
    public abstract class MailHandler
    {
        protected MailHandler nextHandler;
        public MailHandler(MailHandler handler)
        {
            nextHandler = handler;
        }
        public abstract void Handle();
    }
}
