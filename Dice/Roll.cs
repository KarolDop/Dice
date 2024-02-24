using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("DiceTest")]

namespace Dice
{
    internal static class Roll
    {
        internal static int DiceRoll(int wall)
        {
            return new Random().Next(wall) + 1;
        }
    }
}
