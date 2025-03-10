using University.DesignPatterns.Game.Core;
using University.DesignPatterns.Game.Weapons;
using University.DesignPatterns.Game.Weapons.Staffs;

namespace University.DesignPatterns.Game.Characters
{
    public class Mage : Character
    {
        public Mage(string name, Staff weapon, Health health, IResist resist, bool isAlive = true) : base(name, weapon, health, resist, isAlive)
        {

        }

        public override bool ChangeWeapon(Weapon weapon)
        {
            if (weapon is Staff)
            {
                Weapon = weapon;
                return true;
            }

            return false;
        }
    }
}
