using University.DesignPatterns.Game.Core;

namespace University.DesignPatterns.Game.Weapons.Staffs
{
    public class IceStaff : Staff
    {
        private int _debuff;

        public IceStaff() : base(
            "Ледяной посох", 
            new Damage(0, 49), 
            0.6f)
        {
            _debuff = -1;
        }

        public override Damage GetDamage()
        {
            _debuff++;
            var processedDamage = new Damage(_damage.PhysicalDamage, _damage.MagicDamage - _debuff);

            return processedDamage;
        }
    }
}
