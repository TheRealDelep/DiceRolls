using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolls
{
    public static class Dice
    {
        public static int Roll(int numberOfFaces)
        {
            Random random = new Random();
            int result = random.Next(numberOfFaces) + 1;
            return result;
        }
    }
}
