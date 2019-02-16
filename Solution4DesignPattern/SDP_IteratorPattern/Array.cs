using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_IteratorPattern
{
    public class Array : Collection
    {
        private int[] array;
        private int position = 0;

        public Array(int size)
        {
            array = new int[size];
        }

        public override void Add(int val)
        {
            array[position++] = val;
        }

        public override int GetLength()
        {
            return position;
        }

        public override Iterator CreateIterator()
        {
            return new ArrayIterator(array,position);
        }
    }
}
