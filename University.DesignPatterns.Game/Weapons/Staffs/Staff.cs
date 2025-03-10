using University.DesignPatterns.Game.Core;

namespace University.DesignPatterns.Game.Weapons.Staffs
{
    public abstract class Staff : Weapon
    {
        protected Staff(string name, Damage damage, float speed) : base(name, damage, speed)
        {
        }
    }
}
