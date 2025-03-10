namespace University.DesignPatterns.Game.Core
{
    public class Resist : IResist
    {
        public float PhysicalResist { get; }
        public float MagicResist { get; }

        public Resist(float physical, float magic)
        {
            PhysicalResist = physical;
            MagicResist = magic;
        }
    }
}
