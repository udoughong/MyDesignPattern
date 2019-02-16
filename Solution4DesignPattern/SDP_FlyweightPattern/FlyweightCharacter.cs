using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_FlyweightPattern
{
    class FlyweightCharacter
    {
        static int count = 0;
        String font;
        int size;
        char ch;
        public FlyweightCharacter(String font, int size, char ch)
        {
            this.font = font;
            this.size = size;
            this.ch = ch;
            ++count;
        }
        public static int GetCount()
        {
            return count;
        }
    }
}
