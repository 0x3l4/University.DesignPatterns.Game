namespace University.DesignPatterns.Game.Core
{
    public class Damage : IDamage, ICloneable
    {
        public float PhysicalDamage { get; set; }
        public float MagicDamage { get; set; }

        public Damage(float physicalDamage, float magicDamage)
        {
            PhysicalDamage = physicalDamage;
            MagicDamage = magicDamage;
        }

        public static Damage operator +(Damage a, Damage b)
        {
            return new Damage(a.PhysicalDamage + b.PhysicalDamage, a.MagicDamage + b.MagicDamage);
        }

        public static Damage operator -(Damage a, Damage b)
        {
            return new Damage(a.PhysicalDamage - b.PhysicalDamage, a.MagicDamage - b.MagicDamage);
        }

        public static Damage operator *(Damage a, float multiplication)
        {
            return new Damage(a.PhysicalDamage * multiplication, a.MagicDamage * multiplication);
        }

        public object Clone()
        {
            return new Damage(PhysicalDamage, MagicDamage);
        }
    }
}
