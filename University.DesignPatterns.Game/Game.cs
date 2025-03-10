using University.DesignPatterns.Game.Core;
using University.DesignPatterns.Game.Characters;
using University.DesignPatterns.Game.Enemies;
using University.DesignPatterns.Game.Weapons.Staffs;

namespace University.DesignPatterns.Game
{
    public class Game
    {
        public bool IsRunning { get; private set; }
        private Character _character;
        private Enemy _enemy;

        public Game()
        {

        }

        public void Initialize()
        {
            IsRunning = true;

            _character = new Mage(
                "Гэндальф",
                new FireStaff(),
                new Health(300),
                new Resist(1, 0.8f));

            _enemy = new Dragon(
                "Вельдора Темпест",
                new Health(500),
                new Damage(90, 110),
                new Resist(0.5f, 0.5f));
        }

        public void Run()
        {
            Initialize();

            while (IsRunning)
            {
                Console.WriteLine(new string('-', Console.BufferWidth));
                Console.WriteLine($"Имя персонажа: {_character.Name}");
                Console.WriteLine($"Здоровье: {_character.Health.Points}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Оружие: {_character.Weapon.Name}");
                Console.ResetColor();
                Console.WriteLine(new string('-', Console.BufferWidth));
                Console.WriteLine(new string('-', Console.BufferWidth));
                Console.WriteLine($"Имя врага: {_enemy.Name}");
                Console.WriteLine($"Здоровье: {_enemy.Health.Points}");
                Console.WriteLine(new string('-', Console.BufferWidth));
                Console.WriteLine($">{_character.Name} атакует {_enemy.Name}!");
                _character.Attack(_enemy);
                Console.WriteLine($"Осталось здоровья у {_enemy.Name}: {_enemy.Health.Points}");
                Console.WriteLine($">{_enemy.Name} наносит ответный удар!");
                _enemy.Attack(_character);
                Console.WriteLine($"Осталось здоровья у {_character.Name}: {_character.Health.Points}");
                _character.ChangeWeapon(new IceStaff());
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($">{_character.Name} сменил оружие на {_character.Weapon.Name}!");
                Console.ResetColor();
                Console.WriteLine($">{_character.Name} вспоминает былую молодость и наносит серию точных ударов {_enemy.Name}!");
                while (_enemy.IsAlive)
                {
                    _character.Attack(_enemy);
                }

                Console.WriteLine($"{_character.Name} победил!");

                IsRunning = false;
            }
        }
    }
}
