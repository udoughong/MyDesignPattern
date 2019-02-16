using System;

namespace SDP_SingletonPattern
{
    class ThreadPoolManager
    {
        private volatile static ThreadPoolManager _instance;
        private static Object locker = new Object();
        private ThreadPoolManager()
        {
        }
        public static ThreadPoolManager GetInstance()
        {
            if (_instance == null)
            {
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadPoolManager();
                    }
                }
            }
            return _instance;
        }
        internal void AssignTask()
        {
            //
        }
    }
}