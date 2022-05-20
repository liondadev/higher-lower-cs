﻿/*
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
            HLGame game = new HigherLowerGame.HLGame(544);

            while (!game.GameStep())
            {}

            Console.WriteLine("You won!");
        }
    }
}
