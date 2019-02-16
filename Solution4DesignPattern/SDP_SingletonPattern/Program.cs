using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadPoolManager mgr = ThreadPoolManager.GetInstance();
            mgr.AssignTask();
            Console.ReadLine();
        }
    }
}
