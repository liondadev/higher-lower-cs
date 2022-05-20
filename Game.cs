/*
    Game class
    Supports running multiple versions of the game at once.
*/

namespace HigherLowerGame
{
    class HLGame
    {
        public int Number {get; set;} = 0;

        public HLGame(int number)
        {
            if (number == 0)
            {
                try
                {
                    Random rnd = new Random();
                    number = rnd.Next(1, 10000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[HLGame] {ex.Message}");
                }
            }
            else
            {
                Number = number;
            }
        }

        public bool GameStep()
        {
            try
            {
                Console.WriteLine("Guess a number:");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == Number)
                {
                    return true;
                }
                else if (guess < Number)
                {
                    Console.WriteLine("Higher!");
                    return false;
                }
                else if (guess > Number)
                {
                    Console.WriteLine("Lower!");
                    return false;
                }
                else {
                    Console.WriteLine("[HLGame] Somehow the guess wasnt lower, higher, or equal to the guess... How is this even possible?");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[HLGame] {ex.Message}");
                return false;
            }
        }
    }
}
