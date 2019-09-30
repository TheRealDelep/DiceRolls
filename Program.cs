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
            List<Calculable> dices = new List<Calculable>();

            while (input != "q")
            {
                Console.Clear();
                Console.WriteLine("Type in the dices to roll, enter q to exit");
                Console.WriteLine();
                input = Console.ReadLine();

                RollTheDices(ref dices, input);
            }
            Console.WriteLine("Thank you for using our program");
            Console.ReadLine();
        }

        static void RollTheDices(ref List<Calculable> dices, string input)
        {
            int score = 0;

            try
            {
                dices = InputReader.Read(input);
            }
            catch (InvalidInputException exInput)
            {
                if (input != "q")
                {
                    Console.WriteLine(exInput.Message);
                    Console.ReadLine();
                }
                return;
            }

            foreach (Calculable dice in dices)
            {
                score += dice.Calculate();
                dice.PrintResult();
            }
            Console.WriteLine("You scored: " + score);
            Console.ReadLine();
        }
    }
}
