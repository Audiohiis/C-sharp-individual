using System;
namespace DiceRoller
{
    public class Dice
    {
        // properties
        private static readonly Random Random = new Random();
        public string Description { get; }
        public int Sides { get; }

        //constructor
        public Dice(int sides, string description)
        {
            this.Description = description;
            this.Sides = sides;
        }

        //encapsulate objects
        public static Dice D6 => new Dice(6, "d6");
        public static Dice D8 => new Dice(8, "d8");

        public int Roll()
        {
            return Random.Next(1, Sides + 1);
        }
    }
}
