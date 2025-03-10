using University.DesignPatterns.Game.Core;

namespace University.DesignPatterns.Game.Weapons.Swords
{
    public class RustySword : Sword
    {
        public RustySword() : base(
            "Ржавый меч", 
            new Damage(17, 0), 
            0.5f)
        {
        }

        public override Damage GetDamage()
        {
            var processedDamage = new Damage(_damage.PhysicalDamage + new Random().Next(-2, 3), _damage.MagicDamage);
            return processedDamage;
        }
    }
}
