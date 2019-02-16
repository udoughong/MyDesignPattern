using System;

namespace SDP_FactoryMethodPattern
{
    internal class TextDocument : Document
    {
        public override void Open() => Console.WriteLine("[TextDocument] Open");
    }
}
