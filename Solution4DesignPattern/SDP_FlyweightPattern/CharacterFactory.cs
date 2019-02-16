using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_FlyweightPattern
{
    class CharacterFactory
    {
        Dictionary<String, FlyweightCharacter> map = new Dictionary<string, FlyweightCharacter>();
        public FlyweightCharacter GetCharacter(String font, int size, char ch)
        {
            String key = font + size + ch;
            FlyweightCharacter c = null;
            if (map.ContainsKey(key))
            {
                c = map[key];
            }
            else
            {
                c = new FlyweightCharacter(font,size,ch);
                map[key] = c;
            }
            return c;
        }
    }
}
