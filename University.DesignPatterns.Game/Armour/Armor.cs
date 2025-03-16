using University.DesignPatterns.Game.Core;
using University.DesignPatterns.Game.Weapons;

namespace University.DesignPatterns.Game.Armour
{
    public abstract class Armor
    {
        public string Name { get; }

        public Armor(string name)
        {
            Name = name;
        }

        public abstract IDamage ReduceDamage(Weapon weapon);
    }
}