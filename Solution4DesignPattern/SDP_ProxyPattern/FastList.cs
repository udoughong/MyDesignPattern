using System;

namespace SDP_ProxyPattern
{
    class FastList<T>
    {
        private Node<T> head;
        private int size = 0;

        private class Node<T>
        {
            //
        }

        internal void Add(T data)
        {
            Console.WriteLine("[FastList] Add:" + data.ToString());
        }

        internal void Remove(T data)
        {
            Console.WriteLine("[FastList] Remove:" + data.ToString());
        }

        public int GetSize()
        {
            return size;
        }

        public Boolean Contains(T data)
        {
            return false;
        }

    }
}