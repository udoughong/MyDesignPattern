using System;

namespace SDP_DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream();

            CompressedStream cs = new CompressedStream(fs);
            EncryptedStream es = new EncryptedStream(cs);
            es.Write();
            es.Read();

            Console.ReadLine();
        }
    }
}
/*Output:
Encrypting...
Compressing...
Writing...
Reading...
Decompressing...
Decrypting...
*/
