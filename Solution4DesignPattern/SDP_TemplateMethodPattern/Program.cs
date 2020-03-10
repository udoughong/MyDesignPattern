using System;

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
/*Output:
[Document] OpenDialog
[Pdf] ReadHeader
[Pdf] Parse
[Pdf] Format
[Pdf] Display
*/
