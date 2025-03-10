using University.DesignPatterns.Game.Core;
using University.DesignPatterns.Game.Weapons;
using University.DesignPatterns.Game.Weapons.Swords;

namespace University.DesignPatterns.Game.Characters
{
    public class Warrior : Character
    {
        public Warrior(string name, Weapon weapon, Health health, IResist resist, bool isAlive = true) : base(name, weapon, health, resist, isAlive)
        {
        }

        public override bool ChangeWeapon(Weapon weapon)
        {
            if (weapon is Sword)
            {
                Weapon = weapon;
                return true;
            }

            return false;
        }
    }
}
