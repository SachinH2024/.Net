namespace SequeceAlpha
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] testStrings = { "abcd", "abbc", "xab", "a", "bc", "" };

            foreach (string testString in testStrings)
            {
                Console.WriteLine($"{testString}: {IsAlphabetSequence(testString)}");
            }
        }

        public static bool IsAlphabetSequence(string inputString)
        {
            if (string.IsNullOrEmpty(inputString))
            {
                return false; // Empty or null string is not a sequence
            }

            char prevChar = char.ToLower(inputString[0]);

            for (int i = 1; i < inputString.Length; i++)
            {
                char currentChar = char.ToLower(inputString[i]);

                // Check if current character is the next in sequence
                if (currentChar != (char)(prevChar + 1))
                {
                    return false;
                }

                prevChar = currentChar;
            }

            return true;
        }
    }
}
