using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRolls
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<Dice> dices = new List<Dice>();

            while (input != "q")
            {
                WelcomeScreen(ref input);
                RollTheDices(ref dices, input);
            }
        }

        static void WelcomeScreen(ref string input)
        {
            /* Display a welcoming message
             * Receive the user input and transfer it to InputReader
             */
            
            Console.WriteLine("Type in the dices to roll");
            input = Console.ReadLine();  
        }

        static void RollTheDices(ref List<Dice> dices, string input)
        {
            int score = 0;

            try
            {
                dices = InputReader.Read(input);
            }
            catch (InvalidInputException exInput)
            {
                Console.WriteLine(exInput.Message);
                Console.ReadLine();
                return;
            }

            foreach (Dice dice in dices)
            {
                score += dice.Roll();
                dice.PrintResult();
            }

            PrintResult(score);
            Reset(ref input, ref score);
        }

        static void PrintResult(int score)
        {
            Console.WriteLine("You scored: " + score);
            Console.ReadLine();
        }

        static void Reset(ref string input, ref int score)
        {
            /* Reset the members and clear the console
             */
            score = 0;
            input = "";
            Console.Clear();
        }
    }
}
