using System;

namespace SDP_CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            OpenFileCommand cmd = new OpenFileCommand(app);
            Widget w = new Widget();
            w.SetListener(cmd);
            w.SendClick();
            Console.ReadLine();
        }
    }
}
/*Output:
[Widget] SendClick
[OpenFileCommand] Execute
[Application] OpenFile
*/
