using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DesignPatterns.Game.Core;
using University.DesignPatterns.Game.Weapons;
using University.DesignPatterns.Game.Weapons.Staffs;

namespace University.DesignPatterns.Game.Armour
{
    public class Mantle : Armor
    {
        public Mantle() : base("Мантия")
        {
        }

        public override IDamage ReduceDamage(Weapon weapon)
        {
            IDamage reducedDamage;

            if (weapon is Staff)
            {
                reducedDamage = new Damage(
                    weapon.GetDamage().PhysicalDamage, 
                    weapon.GetDamage().MagicDamage * 0.7f);
            }
            else
            {
                reducedDamage = weapon.GetDamage();
            }

            return reducedDamage;
        }
    }
}
