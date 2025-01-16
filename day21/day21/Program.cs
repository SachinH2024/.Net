using day21.Models;

namespace day21
{
    internal class Program
    {
        static void Main()
        {
            Rectangle rectangle1;  // creating Object1 for Rectangle class
            rectangle1 = new Rectangle();  // creating instance of Rectangle class
            rectangle1.width = 10;
            rectangle1.height = 20;
            rectangle1.CalculatedArea();
            Console.WriteLine($"The given Height is {rectangle1.height} and Width is {rectangle1.width} Area of Rectangle1 is: {rectangle1.CalculatedArea()}");

            //Rectangle rectangle2;  // creating Object1 for Rectangle class
            Rectangle rectangle2 = new Rectangle();  // we can create a object and instance in a single line
            rectangle2.width = 100;
            rectangle2.height = 200;
            rectangle2.CalculatedArea();
            Console.WriteLine($"The given Height is {rectangle2.height} and Width is {rectangle2.width} Area of Rectangle1 is: {rectangle2.CalculatedArea()}");

        }
    }
}
