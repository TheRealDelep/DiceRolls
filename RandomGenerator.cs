using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolls
{
    public static class StrongRandom
    {
        private static Random rnd;

        public static Random GetInstance()
        {
            if (rnd == null)
            {
                rnd = new Random();
            }

            return rnd;
        }

        public static int GenerateNumber(int maxValue)
        {
            int result = 0;
            GetInstance();
            result = (rnd.Next(Math.Abs(maxValue)) + 1) * Math.Sign(maxValue);
            return result;
        }

    }









    //int result = 0;
    //Random rnd = new Random();
    //result = (rnd.Next(Math.Abs(maxValue)) + 1) * Math.Sign(maxValue);
    //return result;


}
