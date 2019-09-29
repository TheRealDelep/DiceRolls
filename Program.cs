using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolls
{
    class Program
    {
        static string input = "";
        static int bonus = 0;
        static int score = 0;
        

        static void Main(string[] args)
        {
            WelcomeScreen();
        }

        
        static void WelcomeScreen()
        {
             /* Display a welcoming message
              * Receive the user input and transfer it to InputReader
              */
            Console.WriteLine("Type in the dices to roll");
            input = Console.ReadLine();
            InputReader.Read(input);
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

        static void Reset()
        {
            /* Reset the members and clear the console
             */
            score = 0;
            input = "";
            Console.Clear();
        }
    }
}
