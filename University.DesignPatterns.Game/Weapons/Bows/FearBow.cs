using University.DesignPatterns.Game.Core;

namespace University.DesignPatterns.Game.Weapons.Bows
{
    public class FearBow : Bow
    {
        private float _critChance;
        private float _critMultiplication;

        public FearBow() : base(
            "Страх", 
            new Damage(63, 12), 
            0.4f)
        {
            _critChance = 0.3f;
            _critMultiplication = 1.5f;
        }

        public override Damage GetDamage()
        {
            Random random = new Random();
            Damage processedDamage;
            if (random.NextDouble() <= _critChance)
            {
                processedDamage = _damage * _critMultiplication;
            }
            else
            {
                processedDamage = (Damage)_damage.Clone();
            }
            
            return processedDamage;
        }
    }
}
