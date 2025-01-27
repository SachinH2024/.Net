namespace MaxAdjacentElements
{
    internal class Program
    {
        

        public static void Main(string[] args)
        {
            int[] inputArray = { 5, 2, 5, 7, 3 };
            int result = FindMaxAdjacentProduct(inputArray);
            Console.WriteLine("Max 2 adjacent elements product: " + result); // Output: 35
        }

        public static int FindMaxAdjacentProduct(int[] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException("Array must have at least two elements.");
            }

            int maxProduct = arr[0] * arr[1];

            for (int i = 1; i < arr.Length - 1; i++)
            {
                int product = arr[i] * arr[i + 1];
                maxProduct = Math.Max(maxProduct, product);
            }

            return maxProduct;
        }
    }
}
