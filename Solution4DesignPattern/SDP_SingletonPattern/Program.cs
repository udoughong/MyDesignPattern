using System;

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
/*
 
*/
