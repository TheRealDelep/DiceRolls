using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolls
{
    public class Dice : Calculable
    {
        int faces { get; set; }
        int result { get; set; }

        public Dice(int numberOfFaces)
        {
            faces = numberOfFaces;
            result = 0;
        }

        public int Roll ()
        {
            result = StrongRandom.GenerateNumber(faces);
            return result;
        }

        public int Calculate()
        {
            Roll();
            return result;
        }

        public void PrintResult()
        {
            Console.WriteLine("D" + faces + ": " + result);
        }
    }
}
