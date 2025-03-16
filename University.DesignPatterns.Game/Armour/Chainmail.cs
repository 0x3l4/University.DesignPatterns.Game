using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.DesignPatterns.Game.Core;
using University.DesignPatterns.Game.Weapons;
using University.DesignPatterns.Game.Weapons.Bows;
using University.DesignPatterns.Game.Weapons.Staffs;

namespace University.DesignPatterns.Game.Armour
{
    public class Chainmail : Armor
    {
        public Chainmail() : base("Кольчуга")
        {
        }

        public override IDamage ReduceDamage(Weapon weapon)
        {
            IDamage reducedDamage;

            if (weapon is Staff)
            {
                reducedDamage = new Damage(
                    weapon.GetDamage().PhysicalDamage * 0.8f,
                    weapon.GetDamage().MagicDamage);
            }
            else if (weapon is Bow)
            {
                reducedDamage = new Damage(
                    weapon.GetDamage().PhysicalDamage * 0.9f,
                    weapon.GetDamage().MagicDamage);
            }
            else
            {
                reducedDamage = weapon.GetDamage();
            }

            return reducedDamage;
        }
    }
}
