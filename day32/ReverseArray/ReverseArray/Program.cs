namespace ReverseArray
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] inputArray = { "abc", "pqr", "lmno", "sachin" };
            string[] reversedArray = ReverseArrayInPlace(inputArray);

            Console.WriteLine("Reversed Array:");
            foreach (string str in reversedArray)
            {
                Console.WriteLine(str);
            }
        }

        public static string[] ReverseArrayInPlace(string[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {   
                // Swap elements at left and right indices 
                string temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
            }
            return arr;
        }

    }
}
