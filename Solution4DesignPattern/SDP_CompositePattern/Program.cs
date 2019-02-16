using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
