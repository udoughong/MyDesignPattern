using System;

namespace SDP_TemplateMethodPattern
{
    public abstract class Document
    {
        protected abstract void Parse();
        protected abstract void ReadHeader();
        protected abstract void Format();
        protected abstract void Display();
        void OpenDialog()
        {
            Console.WriteLine("[Document] OpenDialog");
        }
        internal void QuickView()
        {
            OpenDialog();
            ReadHeader();
            Parse();
            Format();
            Display();
        }
    }
}