using System;
using System.Collections.Generic;

namespace SDP_MediatorPattern
{
    class ChatServer
    {
        Dictionary<String, ChatUser> users = new Dictionary<string, ChatUser>();

        public void RegisterUser(ChatUser user)
        {
            if (!users.ContainsValue(user))
            {
                users[user.GetName()] = user;
            }
            user.SetServer(this);
        }

        public void Send(String from, String message)
        {
            foreach (var item in users)
            {
                if (item.Key != from)
                {
                    item.Value.Receive(from, message);
                }
            }
        }
    }
}