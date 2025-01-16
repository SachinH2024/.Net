using System;
using NumberGuessWithOOP.Models;

namespace NumberGuessWithOOP
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NumberGuessGame game = new NumberGuessGame();
            game.Play();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
