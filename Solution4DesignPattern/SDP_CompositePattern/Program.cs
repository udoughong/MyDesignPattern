using System;

namespace SDP_CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Folder folder = new Folder("My Document", "RW", "Blowfish");
            Pdf s1 = new Pdf("Readme.pdf", "RW", "1.0");
            Pdf s2 = new Pdf("SalesReport.pdf", "RWX", "2.0");
            Pdf pdf = new Pdf("Accounts.pdf", "R", "V7");
            folder.AddFile(s1);
            folder.AddFile(s2);
            folder.AddFile(pdf);
            Folder root = new Folder("C:/", "RW", "None");
            root.AddFile(folder);
            root.DisplayInfo();
            Console.ReadLine();
        }
    }
}
/*Output:
Name:C:/
Attributes:RW
Encryption:
Name:My Document
Attributes:RW
Encryption:
Name:Readme.pdf
Attributes:RW
Version:1.0
Name:SalesReport.pdf
Attributes:RWX
Version:2.0
Name:Accounts.pdf
Attributes:R
Version:V7
*/
