using System;

namespace SDP_ProxyPattern
{
    class ThreadSafeList<T>
    {
        private FastList<T> list = new FastList<T>();
        private Object monitor = new Object();
        public void Add(T data)
        {
            Console.WriteLine("Synchronizing Add:" + data.ToString());
            lock (monitor)
            {
                list.Add(data);
            }
        }

        internal void Remove(T data)
        {
            Console.WriteLine("Synchronizing Remove:" + data.ToString());
            lock (monitor)
            {
                list.Remove(data);
            }
        }

        public int GetSize()
        {
            return list.GetSize();
        }
        public Boolean Contains(T data)
        {
            return false;
        }
    }
}