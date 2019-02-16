using System;

namespace SDP_PrototypePattern
{
    class Alien : Monster
    {
        public override void LoadSounds()
        {
            Console.WriteLine("[Alien] Loading sounds");
        }

        public override void LoadTextures()
        {
            Console.WriteLine("[Alien] Loading textures");
        }

        public override void Attack()
        {
            Console.WriteLine("[Alien] Attacking");
        }

        public override Monster Clone()
        {
            return (Alien)this.MemberwiseClone();
        }
    }
}