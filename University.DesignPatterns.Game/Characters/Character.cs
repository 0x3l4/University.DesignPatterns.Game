using University.DesignPatterns.Game.Core;
using University.DesignPatterns.Game.Weapons;

namespace University.DesignPatterns.Game.Characters
{
    public abstract class Character :
        IDamagable, IAttackable
    {
        public string Name { get; protected set; }
        public Health Health { get; protected set; }
        public IResist Resist { get; protected set; }
        public bool IsAlive { get; protected set; }
        public Weapon Weapon { get; protected set; }

        public Character(string name, Weapon weapon, Health health, IResist resist, bool isAlive = true)
        {
            Name = name;
            Weapon = weapon;
            Health = health;
            Resist = resist;
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
            var damage = Weapon.GetDamage();
            target.TakeDamage(damage);
        }

        public abstract bool ChangeWeapon(Weapon weapon);
    }

}
