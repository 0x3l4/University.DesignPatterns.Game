using University.DesignPatterns.Game.Core;

namespace University.DesignPatterns.Game.Weapons.Bows
{
    public abstract class Bow : Weapon
    {
        protected Bow(string name, Damage damage, float speed) : base(name, damage, speed)
        {
        }
    }
}
