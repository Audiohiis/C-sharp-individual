using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceRoller
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            

            Console.WriteLine("> /roll 3d6 2d8");

            Console.WriteLine();

            DiceRoller diceRoller = new DiceRoller();
            List<DiceRoll> diceRolls = diceRoller.Roll(
                new List<Dice> { Dice.D6, Dice.D6, Dice.D6, Dice.D8, Dice.D8});

            foreach (var diceRoll in diceRolls)
            {
                Console.WriteLine($"1{ diceRoll.Dice }: { diceRoll.Value }");
            }

            Console.WriteLine();

            Console.WriteLine($"Roll total: { diceRolls.Sum(x => x.Value) }");
        }
    }
}