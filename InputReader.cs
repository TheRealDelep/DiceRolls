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
        //static void AnalyzeInput()
        //{
        //    string dices = "";
        //    string faces = "";
        //    bool isReadingFaces = false;

        //    input = Console.ReadLine();

        //    foreach (char c in input)
        //    {
        //        if (char.Equals(c, 'd'))
        //        {
        //            isReadingFaces = true;
        //        }
        //        else if (char.Equals(c, '+') || char.Equals(c, '-'))
        //        {
        //            RollTheDice(dices, faces);
        //            dices = c.ToString();
        //            faces = "";
        //            isReadingFaces = false;
        //        }
        //        else if (char.IsDigit(c))
        //        {
        //            if (isReadingFaces == false)
        //            {
        //                dices += c;
        //            }
        //            else
        //            {
        //                faces += c;
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid Input");
        //            Console.ReadLine();
        //            WelcomeScreen();
        //        }
        //    }

        //    RollTheDice(dices, faces);
        //    PrintResult();
        //}

        public static List<Dice> Read(string input)
        {
            List<Dice> dices = new List<Dice>();

            input.Remove(' ');

            if (Regex.IsMatch(input, "^(((? P<sign>(+| -) ?)(?P < coef >[0-9] +))(d(?P < face >[0-9] +)) ?) *$") == false)
            {
                //ThrowError
            }

            else
            {
                Regex.Matches(input, "((? P<sign>(+| -) ?)(?P < coef >[0-9] +))(d(?P < face >[0-9] +)) ?");
            }
            

                


            return dices;
        }

    }
}
