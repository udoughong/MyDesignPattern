using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadSafeList<int> list = new ThreadSafeList<int>();
            list.Add(5);
            list.Add(8);
            list.Remove(5);
            Console.ReadLine();
        }
    }
}
