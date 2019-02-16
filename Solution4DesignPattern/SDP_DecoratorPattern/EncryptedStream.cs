using System;

namespace SDP_DecoratorPattern
{
    class EncryptedStream:Decorator
    {
        public EncryptedStream(Stream s)
            :base(s)
        {
        }

        public override void Write()
        {
            Console.WriteLine("Encrypting...");
            base.Write();
        }

        public override void Read()
        {
            base.Read();
            Console.WriteLine("Decrypting...");
        }
    }
}