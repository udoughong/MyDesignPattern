using System;

namespace SDP_MediatorPattern
{
    class Bot : ChatUser
    {
        public Bot(String name)
            : base(name)
        {
        }
        public override void Send(String message)
        {
            Console.WriteLine("[Bot][" + name + "] Sent:" + message);
        }
        public override void Receive(String from, String message)
        {
            Console.WriteLine("[Bot][" + name + "] Received:" + message);
        }
    }
}