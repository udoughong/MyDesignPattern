using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SpamHandler spam = new SpamHandler(null);
            FanMailHandler fanmail = new FanMailHandler(spam);
            SalesHandler sales = new SalesHandler(fanmail);
            MailServer ms = new MailServer();
            ms.SetHandler(sales);
            ms.ProcessMails();
            Console.ReadLine();
        }
    }
}
