namespace SDP_FactoryMethodPattern
{
    internal class TextDocFactory : DocumentFactory
    {
        public override Document Create => new TextDocument();
    }
}
