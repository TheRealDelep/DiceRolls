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
        public static List<Dice> Read(string input)
        {
            List<Dice> dices = new List<Dice>();

            Regex.Replace(input, @"\s+", "");

            if (Regex.IsMatch(input, @"^(((?<sign>(\+|-)?)(?<coef>\d+))(d(?<face>\d+))?)*$") == false)
            {
                throw new InvalidInputException("You tried to parse: " + input + " and it's not working");
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
                    dices.Add(new Dice(0, rolls * sign));
                }
                else
                {
                    for (int i = 0; i < rolls; i++)
                    {
                        dices.Add(new Dice(faces * sign, 0));
                    }
                }
            }
            return dices;
        }
    }
}
