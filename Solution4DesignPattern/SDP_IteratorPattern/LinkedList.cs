using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_IteratorPattern
{
    public class LinkedList : Collection
    {
        public class Node
        {
            private int data;
            private Node next;
            public Node(int data)
            {
                this.data = data;
                next = null;
            }
            public int GetData()
            {
                return data;
            }
            public Node GetNext()
            {
                return next;
            }
            public void SetNode(Node n)
            {
                next = n;
            }
        }
        private Node head;
        private int size = 0;
        public override void Add(int data)
        {
            if (size == 0)
            {
                head = new Node(data);
            }
            else
            {
                Node temp = null;
                for (temp = head; temp.GetNext() != null; temp = temp.GetNext()) ;
                temp.SetNode(new Node(data));
            }
            ++size;
        }

        public override Iterator CreateIterator()
        {
            return new ListIterator(head);
        }

        public override int GetLength()
        {
            return size;
        }
    }
}
