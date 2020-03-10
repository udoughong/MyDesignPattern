using System;

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
/*Output:
Synchronizing Add:5
[FastList] Add:5
Synchronizing Add:8
[FastList] Add:8
Synchronizing Remove:5
[FastList] Remove:5
*/
