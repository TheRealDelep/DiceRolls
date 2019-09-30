using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolls
{
    class Bonus : Calculable
    {
        int value;
        string type;

        public Bonus(int value)
        {
            this.value = value;
            type = value > 0 ? "Bonus: " : "Malus: ";
        }

        public int Calculate()
        {
            return value;
        }

        public void PrintResult()
        {
            Console.WriteLine(type + value);
        }
    }
}
