using System;

namespace SDP_TemplateMethodPattern
{
    class Pdf : Document
    {
        protected override void Parse()
        {
            Console.WriteLine("[Pdf] Parse");
        }
        protected override void ReadHeader()
        {
            Console.WriteLine("[Pdf] ReadHeader");
        }
        protected override void Format()
        {
            Console.WriteLine("[Pdf] Format");
        }
        protected override void Display()
        {
            Console.WriteLine("[Pdf] Display");
        }
    }
}