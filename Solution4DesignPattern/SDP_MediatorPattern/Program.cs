using System;

namespace SDP_MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatServer server = new ChatServer();
            Bot bot1 = new Bot("Robo");
            HumanUser user1 = new HumanUser("Shafiq");
            HumanUser user2 = new HumanUser("Sameer");
            server.RegisterUser(bot1);
            server.RegisterUser(user1);
            server.RegisterUser(user2);
            user1.Send("Hello, everyone!");
            user2.Send("What's up");
            Console.ReadLine();
        }
    }
}
/*Output:
[HumanUser][Shafiq] Sent:Hello, everyone!
[Bot][Robo] Received:Hello, everyone!
[HumanUser][Sameer] Received:Hello, everyone!
[HumanUser][Sameer] Sent:What's up
[Bot][Robo] Received:What's up
[HumanUser][Shafiq] Received:What's up
*/
