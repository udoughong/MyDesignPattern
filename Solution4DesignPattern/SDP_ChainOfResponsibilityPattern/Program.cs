using System;

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
/*Output:
[SalesHandler] Handle
[FanMailHandler] Handle
[SpamHandler] Handle
End of chain
*/
