namespace Delegates
{

    delegate void DMathOper(int a, int b);

    internal class Program
    {
        

        public static void Main(string[] args)
        {
            // Create an instance of the delegate
            DMathOper mathOperation = null;


            mathOperation += Add;
            mathOperation += Sub;
            mathOperation += Mul;

            
            Console.WriteLine("Executing operations with x(10, 2):");
            mathOperation(10, 2);

            
            mathOperation -= Sub;

            
            Console.WriteLine("\nExecuting operations again after removing Sub:");
            mathOperation(10, 2);

            Console.ReadKey(); 
        }

        static void Add(int a, int b)
        {
            Console.WriteLine($"Add: {a} + {b} = {a + b}");
        }

        static void Sub(int a, int b)
        {
            Console.WriteLine($"Subtract: {a} - {b} = {a - b}");
        }

        static void Mul(int a, int b)
        {
            Console.WriteLine($"Multiply: {a} * {b} = {a * b}");
        }
    }
}
