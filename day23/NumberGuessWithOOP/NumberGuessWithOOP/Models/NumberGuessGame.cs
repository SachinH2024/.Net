using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessWithOOP.Models
{
    public class NumberGuessGame
    {
        private int randomNumber;
        private int attemptsRemaining;

        public NumberGuessGame()
        {
            // Generate a random number between 1 and 100
            Random random = new Random();
            randomNumber = random.Next(1, 101);
            attemptsRemaining = 3;
        }

        public void Play()
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I've chosen a random number between 1 and 100.");

            while (attemptsRemaining > 0)
            {
                Console.Write("Enter your guess: ");
                int guess = int.Parse(Console.ReadLine());

                if (guess == randomNumber)
                {
                    Console.WriteLine("Congratulations! You guessed the number.");
                    return;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Too low!");
                }
                else
                {
                    Console.WriteLine("Too high!");
                }

                attemptsRemaining--;
                Console.WriteLine($"Attempts remaining: {attemptsRemaining}");
            }

            Console.WriteLine($"You've run out of attempts. The number was {randomNumber}.");
        }
    }
}
