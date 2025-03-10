using University.DesignPatterns.Game.Core;

namespace University.DesignPatterns.Game.Enemies
{
    public abstract class Enemy :
        IAttackable, IDamagable
    {
        public string Name { get; protected set; }
        public Health Health { get; protected set; }
        public Damage Damage { get; protected set; }
        public IResist Resist { get; protected set; }
        public bool IsAlive { get; protected set; }

        public Enemy(string name, Health health, Damage damage, IResist resist, bool isAlive = true)
        {
            Name = name;
            Health = health;
            Resist = resist;
            Damage = damage;
            IsAlive = isAlive;
        }

        public void TakeDamage(IDamage damage)
        {
            if (Health.Points > 0)
            {
                Health.Points -= Math.Max(
                damage.PhysicalDamage * Resist.PhysicalResist +
                damage.MagicDamage * Resist.MagicResist, 0);
                if (Health.Points <= 0)
                {
                    IsAlive = false;
                }
            }
        }

        public void Attack(IDamagable target)
        {
            var damage = Damage;
            target.TakeDamage(damage);
        }
    }
}
