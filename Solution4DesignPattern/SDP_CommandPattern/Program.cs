using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
