namespace SDP_IteratorPattern
{
    public abstract class Iterator
    {
        public abstract void First();
        public abstract void Next();
        public abstract bool HasNext();
        public abstract int CurrentItem();
    }
}