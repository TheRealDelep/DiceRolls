using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolls
{
    public class Dice
    {
        int faces { get; set; }
        int result { get; set; }

        public Dice(int numberOfFaces)
        {
            faces = numberOfFaces;
            result = 0;
        }

        public void Roll ()
        {
             result = new Random().Next(faces) +1;
        }

        public void PrintResult()
        {
            Console.WriteLine("D" + faces + ": " + result);
        }
    }
}
