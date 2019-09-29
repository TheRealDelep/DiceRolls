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
            Reset();
            Console.WriteLine("Type in the dices to roll");
            input = Console.ReadLine();
            RollTheDices();
        }

        static void RollTheDices()
        {
            foreach (Dice dice in InputReader.Read(input))
            {
                score += dice.Roll();
                dice.PrintResult();
            }
            PrintResult();
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
