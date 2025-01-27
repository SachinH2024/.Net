using PrintSalarySlip.Models;

namespace PrintSalarySlip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Sachin H", 50000, 10000, 5000);
            Developer developer = new Developer("Nitin L", 40000, 8000);

            manager.PrintSalarySlip();
            Console.WriteLine();
            developer.PrintSalarySlip();

            Console.ReadLine(); // Keep the console window open
        }
    }
}
