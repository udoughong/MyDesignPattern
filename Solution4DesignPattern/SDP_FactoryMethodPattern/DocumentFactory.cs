namespace SDP_FactoryMethodPattern
{
    internal abstract class DocumentFactory
    {
        public abstract Document Create { get; }

        public Document GetCreateDocument()
        {
            Document d = Create;
            return d;
        }
    }
}
