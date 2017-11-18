using System;
using System.Collections.Generic;
using System.Linq;

namespace DiceRoller
{
    public class DiceRollCommandParser
    {
        public List<Dice> CommandParser(string userInput)
        {
            var inputDiceList = new List<Dice>();
            List<String> userInputList = userInput.Split(' ').ToList();

            foreach (var listElement in userInputList)
            {
                if (listElement.Contains('d'))
                {
                    string[] rollsAndType = listElement.Split('d');

                    for (var i = 0; i < Int32.Parse(rollsAndType[0]); i++)
                    {
                        if (rollsAndType[1] == "4")
                        {
                            inputDiceList.Add(Dice.D4);
                        }
                        else if (rollsAndType[1] == "6")
                        {
                            inputDiceList.Add(Dice.D6);
                        }
                        else if (rollsAndType[1] == "8")
                        {
                            inputDiceList.Add(Dice.D8);
                        }
                        else if (rollsAndType[1] == "10")
                        {
                            inputDiceList.Add(Dice.D10);
                        }
                        else if (rollsAndType[1] == "12")
                        {
                            inputDiceList.Add(Dice.D12);
                        }
                        else if (rollsAndType[1] == "20")
                        {
                            inputDiceList.Add(Dice.D20);
                        }
                    }
                }
            }
            return inputDiceList;
        }
    }
}
