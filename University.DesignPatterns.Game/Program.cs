
namespace University.DesignPatterns.Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Гладиаторские бои";
            Game game = new Game();
            game.Run();
        }
    }
}
