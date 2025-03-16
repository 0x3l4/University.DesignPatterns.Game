using University.DesignPatterns.Game.Characters;
using University.DesignPatterns.Game.Weapons.Staffs;

namespace University.DesignPatterns.Game.Scenarios
{
    public class ScenarioA : IScenario
    {
        public void Scenario()
        {
            Character character = new Mage("player123",
                new FireStaff(),
                );
        }
    }
}
