using University.DesignPatterns.Game.Core;

namespace University.DesignPatterns.Game.Weapons.Swords
{
    public abstract class Sword : Weapon
    {
        public Sword(string name, Damage damage, float speed) : base(name, damage, speed)
        {
        }
    }
}