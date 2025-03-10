using University.DesignPatterns.Game.Core;

namespace University.DesignPatterns.Game.Weapons
{
    public abstract class Weapon
    {
        protected Damage _damage;

        public string Name { get; protected set; }
        public float Speed { get; protected set; }

        public Weapon(string name, Damage damage, float speed)
        {
            Name = name;
            _damage = damage;
            Speed = speed;
        }

        public abstract Damage GetDamage();
    }
}
