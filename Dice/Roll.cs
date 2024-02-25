using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DiceTest.UnitTest")]

namespace Dice
{
    internal static class Roll
    {
        internal static int DiceRoll(int wall)
        {
            return new Random().Next(wall) + 1;
        }

        internal static void Throw(List<NewDice> Dice)
        {
            foreach(NewDice dice in Dice)
            {
                dice.NewRoll();
            }
        }
    }
}
