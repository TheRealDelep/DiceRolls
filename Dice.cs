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
        int bonus {  get; set; }
        
        public bool isBonus { get; private set; }
        string bonusMalus;

        public Dice(int numberOfFaces, int bonusAmount)
        {
            faces = numberOfFaces;
            bonus = bonusAmount;
            if (faces == 0)
            {
                isBonus = true;
                bonusMalus = bonus > 0 ? "Bonus: " : "Malus: ";
            }
            result = 0;
        }

        public int Roll ()
        {
            if (isBonus)
            {
                result = bonus;
            }
            else
            {
                result = StrongRandom.GenerateNumber(faces);
            }
            return result;
        }

        public void PrintResult()
        {
            if (isBonus)
            {
                Console.WriteLine(bonusMalus + bonus);
            }
            else
            {
                Console.WriteLine("D" + faces + ": " + result);
            }
        }
    }
}
