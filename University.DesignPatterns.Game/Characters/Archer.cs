using University.DesignPatterns.Game.Core;
using University.DesignPatterns.Game.Weapons;
using University.DesignPatterns.Game.Weapons.Bows;

namespace University.DesignPatterns.Game.Characters
{
    public class Archer : Character
    {
        public Archer(string name, Weapon weapon, Health health, IResist resist, bool isAlive = true) : base(name, weapon, health, resist, isAlive)
        {
        }

        public override bool ChangeWeapon(Weapon weapon)
        {
            if (weapon is Bow)
            {
                Weapon = weapon;
                return true;
            }

            return false;
        }
    }
}
