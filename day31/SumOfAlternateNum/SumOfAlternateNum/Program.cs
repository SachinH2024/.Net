
using System;

namespace SumOfAlternateNum
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] inputArray = { 10, 20, 30, 40, 50 };
            int[] resultArray = SumOfAlternateNumbers(inputArray);

            Console.WriteLine("Input array: [{0}]", string.Join(", ", inputArray));
            Console.WriteLine("Output array: [{0}]", string.Join(", ", resultArray));
        }


        public static int[] SumOfAlternateNumbers(int[] inputArray)
        {
            if (inputArray == null || inputArray.Length == 0)
            {
                return new int[0]; // Return empty array for invalid input
            }

            int[] resultArray = new int[2]; // Array to store the two sums
            resultArray[0] = 0; // Initialize first sum to 0
            resultArray[1] = 0; // Initialize second sum to 0

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i % 2 == 0) // Check if index is even
                {
                    resultArray[0] += inputArray[i]; // Add to first sum
                }
                else
                {
                    resultArray[1] += inputArray[i]; // Add to second sum
                }
            }

            return resultArray;
        }

    }
}
