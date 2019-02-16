namespace SDP_IteratorPattern
{
    public class ListIterator : Iterator
    {
        private LinkedList.Node reference, head;

        public ListIterator(LinkedList.Node reference)
        {
            this.head = this.reference = reference;
        }

        public override int CurrentItem()
        {
            return reference.GetData();
        }

        public override void First()
        {
            reference = head;
        }

        public override bool HasNext()
        {
            return reference == null ? false : true;
        }

        public override void Next()
        {
            reference = reference.GetNext();
        }
    }
}