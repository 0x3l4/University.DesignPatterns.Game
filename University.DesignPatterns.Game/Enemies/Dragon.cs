using University.DesignPatterns.Game.Core;

namespace University.DesignPatterns.Game.Enemies
{
    public class Dragon : Enemy
    {
        public Dragon(string name, Health health, Damage damage, IResist resist, bool isAlive = true) : base(name, health, damage, resist, isAlive)
        {
        }
    }
}
