namespace SDP_PrototypePattern
{
    abstract class Monster
    {
        public abstract void Attack();
        public abstract void LoadTextures();
        public abstract void LoadSounds();
        public abstract Monster Clone();
    }
}