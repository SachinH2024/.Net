using System;


namespace ArrayApp
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            string[] inputArray = { "abc", "def" };
            string[] outputArray = GenerateOutputArray(inputArray);

            foreach (string row in outputArray)
            {
                Console.WriteLine(row);
            }
        }

        public static string[] GenerateOutputArray(string[] inputArray)
        {
            int maxLength = inputArray.Length + 2;
            string[] outputArray = new string[maxLength];

            outputArray[0] = new string('*', maxLength);

            for (int i = 0; i < inputArray.Length; i++)
            {
                outputArray[i + 1] = "*" + inputArray[i] + "*";
            }

            outputArray[maxLength - 1] = new string('*', maxLength);

            return outputArray;

        }
    }
}
