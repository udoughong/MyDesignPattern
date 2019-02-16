using System;

namespace SDP_FactoryMethodPattern
{
    internal class SpreadSheetDocument : Document
    {
        public override void Open() => Console.WriteLine("[SpreadSheetDocument] Open");
    }
}
