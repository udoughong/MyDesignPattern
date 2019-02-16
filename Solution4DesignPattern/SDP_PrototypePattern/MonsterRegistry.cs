using System;
using System.Collections.Generic;

namespace SDP_PrototypePattern
{
    class MonsterRegistry
    {
        public Monster CreateMonster(String monstername)
        {
            Monster m = null;
            switch (monstername)
            {
                case "Cyborg":
                    m = new Cyborg();
                    break;
                case "Alien":
                    m = new Alien();
                    break;
                case "Acid":
                    m = new Acid();
                    break;
            }
            m.LoadSounds();
            m.LoadTextures();
            return m;
        }
        private Dictionary<String, Monster> registry = new Dictionary<string, Monster>();//[2]
        public void RegisterMonster(String name, Monster monster)
        {
            if (!registry.ContainsKey(name))
            {
                monster.LoadSounds();
                monster.LoadTextures();
                registry.Add(name, monster);
            }
        }
        public Monster GetMonster(String name)
        {
            if (registry.ContainsKey(name))
                return registry[name].Clone();
            throw new NotSupportedException("Monster not registered");
        }
    }
}