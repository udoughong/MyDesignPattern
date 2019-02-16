using System;
using System.IO;

namespace SDP_DecoratorPattern
{
    class CompressedStream:Decorator
    {
        public CompressedStream(Stream s)
            :base(s)
        {
        }
        public override void Write()
        {
            Console.WriteLine("Compressing...");
            base.Write();
        }
        public override void Read()
        {
            base.Read();
            Console.WriteLine("Decompressing...");
        }
    }
}