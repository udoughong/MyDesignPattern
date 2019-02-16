using System;

namespace SDP_MediatorPattern
{
    abstract class ChatUser
    {
        protected String name;
        protected ChatServer server;

        public void SetServer(ChatServer server)
        {
            this.server = server;
        }

        public ChatUser(String name)
        {
            this.name = name;
        }
        
        public String GetName()
        {
            return name;
        }

        public abstract void Send(String message);
        public abstract void Receive(String from, String message);
    }
}