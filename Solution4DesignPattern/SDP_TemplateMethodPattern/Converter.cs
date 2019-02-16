using System;

namespace SDP_TemplateMethodPattern
{
    public class Converter
    {
        private Document document;
        public void SetDocument(Document doc)
        {
            document = doc;
        }
        public void View()
        {
            document.QuickView();
        }
    }
}