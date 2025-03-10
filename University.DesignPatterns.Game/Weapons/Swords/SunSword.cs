using University.DesignPatterns.Game.Core;

namespace University.DesignPatterns.Game.Weapons.Swords
{
    public class SunSword : Sword
    {
        private float _combo;

        public SunSword() : base(
            "Меч Солнца", 
            new Damage(112, 63), 
            0.45f)
        {
            _combo = 1;
        }

        public override Damage GetDamage()
        {
            _combo += 0.1f;
            return _damage * _combo;
        }
    }
}
