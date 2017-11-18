using System;
using System.Collections.Generic;

namespace DiceRoller
{
    public class DiceRoller
    {
        public List<DiceRoll> Roll(List<Dice> dices)
        {
            var rollResult = new List<DiceRoll>();

            foreach (var dice in dices)
            {
                rollResult.Add(new DiceRoll(dice.Description, dice.Roll()));
            }
            return rollResult;
        }
    }
}
