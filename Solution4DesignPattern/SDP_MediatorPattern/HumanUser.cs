using System;

namespace SDP_MediatorPattern
{
    class HumanUser : ChatUser
    {
        public HumanUser(String name)
            : base(name)
        {
        }

        public override void Send(String message)
        {
            Console.WriteLine("[HumanUser][" + name + "] Sent:" + message);
            server.Send(name, message);
        }

        public override void Receive(String from, String message)
        {
            Console.WriteLine("[HumanUser][" + name + "] Received:" + message);
        }
    }
}