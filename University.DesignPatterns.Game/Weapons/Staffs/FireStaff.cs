using University.DesignPatterns.Game.Core;

namespace University.DesignPatterns.Game.Weapons.Staffs
{
    public class FireStaff : Staff
    {
        private int _magicBuff;

        public FireStaff() : base(
            "Огненный посох", 
            new Damage(0, 56), 
            0.7f)
        {
            _magicBuff = -1;
        }

        public override Damage GetDamage()
        {
            _magicBuff++;
            var processedDamage = new Damage(_damage.PhysicalDamage, _damage.MagicDamage + _magicBuff);

            return processedDamage;
        }
    }
}
