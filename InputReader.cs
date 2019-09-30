using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DiceRolls
{
    public static class InputReader
    {
        public static List<Calculable> Read(string input)
        {
            List<Calculable> dices = new List<Calculable>();

            Regex.Replace(input, @"\s+", "");

            if (Regex.IsMatch(input, @"^(((?<sign>(\+|-)?)(?<coef>\d+))(d(?<face>\d+))?)*$") == false)
            {
                throw new InvalidInputException("Invalid Input");
            }

            Regex regex = new Regex(@"((?<sign>(\+|-)?)(?<coef>[0-9]+))(d(?<face>[0-9]+))?");

            foreach (Match match in regex.Matches(input))
            {
                int rolls = int.Parse(match.Groups["coef"].Value);

                int faces = 0;
                int sign = 1;
                int.TryParse(match.Groups["face"].Value, out faces);
                int.TryParse(match.Groups["sign"].Value + "1", out sign);

                if (faces == 0)
                {
                    dices.Add(new Bonus(rolls * sign));
                }
                else
                {
                    for (int i = 0; i < rolls; i++)
                    {
                        dices.Add(new Dice(faces * sign));
                    }
                }
            }
            return dices;
        }
    }
}
