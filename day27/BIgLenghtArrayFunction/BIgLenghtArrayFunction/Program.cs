namespace BIgLenghtArrayFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "abc", "abcd", "efgg" };
            string[] longestArray = FindLongestString(inputArray);

            Console.WriteLine(longestArray);
            foreach (string str in longestArray)
            {
                Console.WriteLine(str);
            }
        }

        public static string[] FindLongestString(string[] inputArray)
        {
            if(inputArray==null||inputArray.Length==0)
            {
                return new string[0];
            }
            
            int maxLength=inputArray.Max(s => s.Length);
            return inputArray.Where(s => s.Length==maxLength).ToArray();

        }
    }
}
