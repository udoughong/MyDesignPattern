using System;

namespace SDP_PrototypePattern
{
    class Acid : Monster
    {
        public override void LoadSounds()
        {
            Console.WriteLine("[Acid] Loading sounds");
        }

        public override void LoadTextures()
        {
            Console.WriteLine("[Acid] Loading textures");
        }

        public override void Attack()
        {
            Console.WriteLine("[Acid] Attacking");
        }

        public override Monster Clone()
        {
            return (Acid)this.MemberwiseClone();
        }
    }
}