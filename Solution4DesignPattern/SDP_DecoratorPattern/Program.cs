using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
