using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    internal static class Roll
    {
        internal static int DiceRoll(int wall)
        {
            return new Random().Next(6);
        }
    }
}
