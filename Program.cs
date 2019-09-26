using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolls
{
    class Program
    {
        static int score = 0;

        static string input;

        static void Main(string[] args)
        {
            WelcomeScreen();
        }

        static void WelcomeScreen()
        {
            score = 0;
            Console.Clear();
            Console.WriteLine("Type in the dices to roll");
            AnalyzeInput();
        }

        static void AnalyzeInput()
        {
            string dices = "";
            string faces = "";
            bool isReadingFaces = false;

            input = Console.ReadLine();

            foreach (char c in input)
            {
                if (char.Equals(c, 'd'))
                {
                    isReadingFaces = true;
                }
                else if (char.Equals(c, '+') || char.Equals(c, '-'))
                {
                    RollTheDice(dices, faces);
                    dices = c.ToString();
                    faces = "";
                    isReadingFaces = false;
                }
                else if (char.IsDigit(c))
                {
                    if (isReadingFaces == false)
                    {
                        dices += c;
                    }
                    else
                    {
                        faces += c;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadLine();
                    WelcomeScreen();
                }
            }

            RollTheDice(dices, faces);
            PrintResult();
        }

        static void RollTheDice(string dices, string faces)
        {
            int numberOfDices = 0;
            int numberOfFaces = 0;

            int.TryParse(dices, out numberOfDices);
            int.TryParse(faces, out numberOfFaces);

            int result = 0;

            for (int i = 0; i < Math.Abs(numberOfDices); i++)
            {
                result += Dice.Roll(numberOfFaces);
            }
            result *= Math.Sign(numberOfDices);
            score += result;

        }

        static void PrintResult()
        {
            Console.WriteLine("You scored: " + score);
            Console.ReadLine();
            WelcomeScreen();
        }
    }
}
