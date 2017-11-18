using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceRoller
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            DiceRollCommandParser commandParser = new DiceRollCommandParser();
            List<Dice> commandList = commandParser.CommandParser(userInput);

            DiceRoller diceRoller = new DiceRoller();
            List<DiceRoll> diceRolls = diceRoller.Roll(commandList);

            foreach (var diceRoll in diceRolls)
            {
                Console.WriteLine($"1{ diceRoll.Dice }: { diceRoll.Value }");
            }

            Console.WriteLine($"Roll total: { diceRolls.Sum(x => x.Value) }");
        }
    }
}