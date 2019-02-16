using System;

namespace SDP_DecoratorPattern
{
    public class FileStream : Stream
    {
        public override void Write()
        {
            Console.WriteLine("Writing...");
        }

        public override void Read()
        {
            Console.WriteLine("Reading...");
        }
    }
}