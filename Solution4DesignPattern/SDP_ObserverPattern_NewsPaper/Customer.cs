using System;

namespace SDP_ObserverPattern_NewsPaper
{
    public class Customer : IObserver
    {
        public string MyName { private get; set; }

        public string Name => MyName;

        public Customer(string pName)
        {
            MyName = pName;
        }

        // 更新最新消息
        public void Update(string pMessage)
        {
            Console.WriteLine("   {0} receive a new message:{1}", MyName, pMessage);
        }
    }
}