using System;

namespace NextAlpha
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string inputString = "abcd";
            string outputString = StringExtensions.NextAlphabet(inputString);

            Console.WriteLine($"Input string: {inputString}");
            Console.WriteLine($"Output string: {outputString}");
        }

        public class StringExtensions
        {
            public static string NextAlphabet(string input)
            {
                char[] chars = input.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                {
                    chars[i] = (char)(chars[i] + 1);
                }
                return new string(chars);
            }
        }
    }
}
