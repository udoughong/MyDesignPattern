namespace SDP_IteratorPattern
{
    public class ArrayIterator : Iterator
    {
        private int[] reference = null;
        private int pos = 0;
        private int size = 0;

        public ArrayIterator(int[] reference, int size)
        {
            this.reference = reference;
            this.size = size;
        }

        public override int CurrentItem()
        {
            return reference[pos];
        }

        public override void First()
        {
            pos = 0;
        }

        public override bool HasNext()
        {
            return pos < size ? true : false;
        }

        public override void Next()
        {
            ++pos;
        }
    }
}