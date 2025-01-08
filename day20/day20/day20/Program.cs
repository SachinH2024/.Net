using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Error: Name cannot be empty or contain only whitespace.");
            return;
        }

        if (name.Contains(" "))
        {
            Console.WriteLine("Error: Spaces are not allowed.");
            return;
        }

        if (name.Any(char.IsDigit))
        {
            Console.WriteLine("Error: Numbers are not allowed.");
            return;
        }

        if (name.Any(c=>! char.IsLetter(c)))
        {
            Console.WriteLine("Error: Special Characters are not allowed.");
            return;
        }

        Console.WriteLine("Correct! Your name is: " + name);
        Console.ReadLine();
    }
}
