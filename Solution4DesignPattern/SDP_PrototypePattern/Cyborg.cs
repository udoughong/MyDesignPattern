using System;

namespace SDP_PrototypePattern
{
    class Cyborg : Monster
    {
        public override void LoadSounds()
        {
            Console.WriteLine("[Cyborg] Loading sounds");
        }

        public override void LoadTextures()
        {
            Console.WriteLine("[Cyborg] Loading textures");
        }

        public override void Attack()
        {
            Console.WriteLine("[Cyborg] Attacking");
        }

        public override Monster Clone()
        {
            return (Cyborg)this.MemberwiseClone();
        }
    }
}