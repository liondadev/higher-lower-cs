/*
    Higher/Lower Number game written in C#
    Made so I can better understand the C# language.
*/

using HigherLowerGame; // Namespace containing the class of the game

namespace HigherLower
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number 1-9999. We'll let you know if the number is higher or lower than your guess!\n");
            Random random = new Random();
            int num = random.Next(1, 9999);
            HLGame game = new HigherLowerGame.HLGame(num);

            Console.WriteLine(num);

            while (!game.GameStep())
            {}

            Console.WriteLine("You won!");

            Console.WriteLine("Press any key to close!");
            Console.ReadKey();
        }
    }
}
