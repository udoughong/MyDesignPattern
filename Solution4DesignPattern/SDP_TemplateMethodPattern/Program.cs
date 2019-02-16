using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Pdf pdf = new Pdf();
            Converter cnv = new Converter();
            cnv.SetDocument(pdf);
            cnv.View();
            Console.ReadLine();
        }
    }
}
