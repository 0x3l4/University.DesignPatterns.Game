namespace University.DesignPatterns.Game.Core
{
    public class Health : IHealth
    {
        public float Points { get; set; }

        public Health(float points)
        {
            Points = points;
        }

        public static Health operator +(Health a, Health b)
        {
            return new Health(a.Points + b.Points);
        }

        public static Health operator -(Health a, Health b)
        {
            return new Health(a.Points + b.Points);
        }
    }
}
