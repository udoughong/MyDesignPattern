using System;

namespace SDP_CommandPattern
{
    class Widget
    {
        CommandListener listener;
        public void SetListener(CommandListener l)
        {
            listener = l;
        }

        public void SendClick()
        {
            Console.WriteLine("[Widget] SendClick");
            listener.Execute();
        }
    }
}