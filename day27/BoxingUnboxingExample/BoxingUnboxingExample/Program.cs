namespace BoxingUnboxingExample
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // object array with integer values
            object[] objArray = { 10, 20, 30, 40, 50 };

            int sum = 0;

            // unbox each object to int
            foreach (object obj in objArray)
            {
                int value = (int)obj; // Unboxing
                sum += value;
            }

            // Calculate average
            double average = (double)sum / objArray.Length;

            // Display results
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + average);

            Console.ReadLine();
        }
    }
}
