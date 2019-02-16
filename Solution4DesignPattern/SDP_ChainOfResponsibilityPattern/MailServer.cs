using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_ChainOfResponsibilityPattern
{
    class MailServer
    {
        MailHandler handler;
        public void SetHandler(MailHandler handler)
        {
            this.handler = handler;
        }
        public void ProcessMails()
        {
            handler.Handle();
        }
    }
}
