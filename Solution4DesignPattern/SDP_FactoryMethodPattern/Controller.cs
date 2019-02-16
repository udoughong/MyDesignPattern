namespace SDP_FactoryMethodPattern
{
    internal class Controller
    {
        private Document document;
        private DocumentFactory factory;
        public Controller()
        {
        }

        public void SetFactory(DocumentFactory factory) => this.factory = factory;

        public void Initialize()
        {
            document = factory.GetCreateDocument();
            document.Open();
        }
    }
}
