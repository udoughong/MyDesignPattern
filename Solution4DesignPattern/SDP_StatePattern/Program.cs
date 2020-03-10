using System;

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
/*Output:
Current user is SDP_StatePattern.Administrator.
[Administrator] Writing Data
[Administrator] Viewing Data
Current user is SDP_StatePattern.Programmer.
[Programmer] Cannot write Data
[Programmer] Viewing Data
Current user is SDP_StatePattern.Guest.
[Guest] Cannot write Data
[Guest] Cannot view Data
*/
