using University.DesignPatterns.Game.Core;

namespace University.DesignPatterns.Game.Weapons.Bows
{
    public class ClassicBow : Bow
    {
        public ClassicBow() : base(
            "Классический лук", 
            new Damage(30, 0), 
            0.5f)
        {
        }

        public override Damage GetDamage()
        {
            var processedDamage = 
                new Damage(_damage.PhysicalDamage + new Random().Next(-5, 5), _damage.MagicDamage);

            return processedDamage;
        }
    }
}
