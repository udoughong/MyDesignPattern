using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_StatePattern
{
    class Program
    {
        static DbTable table = new DbTable();
        static void Main(string[] args)
        {
            UseTable(new Administrator());
            UseTable(new Programmer());
            UseTable(new Guest());
            Console.ReadLine();
        }

        private static void UseTable(User user)
        {
            table.SetUser(user);
            table.DisplayState();
            table.Write();
            table.View();
        }
    }
}
