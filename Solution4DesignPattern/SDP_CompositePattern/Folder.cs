using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_CompositePattern
{
    class Folder : File
    {
        private List<File> files = new List<File>();
        private String encryption;
        public Folder(String name, String attributes, String encryption)
            : base(name, attributes)
        {
        }
        public void AddFile(File file)
        {
            files.Add(file);
        }
        public void RemoveFile(File file)
        {
            files.Remove(file);
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("Name:{0}", name);
            Console.WriteLine("Attributes:{0}", attributes);
            Console.WriteLine("Encryption:{0}", encryption);
            foreach (var file in files)
            {
                file.DisplayInfo();
            }
        }
    }
}
