using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_FlyweightPattern
{
    class Character
    {
        static int count = 0;
        String font;
        int size;
        char ch;
        Position pos;
        public Character(String font,int size,char ch,Position pos)
        {
            this.font = font;
            this.size = size;
            this.ch = ch;
            this.pos = pos;
            ++count;
        }
        public char GetCharacter()
        {
            return ch;
        }
        public int GetSize()
        {
            return size;
        }
        public String GetFont()
        {
            return font;
        }
        public Position GetPosition()
        {
            return pos;
        }
        public static int GetCount()
        {
            return count;
        }
    }
}
