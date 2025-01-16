using System;
using FindLargestRect.Models;


class Program
{
    static void Main(string[] args)
    {
        Rectangle[] rectangles = new Rectangle[]
        {
            new Rectangle(3, 4),
            new Rectangle(5, 2),
            new Rectangle(1, 6),
            new Rectangle(8, 1),
            new Rectangle(2, 2)
        };

        // Print information about each rectangle
        foreach (Rectangle rect in rectangles)
        {
            Console.WriteLine(rect);
        }

        // Find the rectangle with the largest area
        Rectangle biggestRectangle = FindBiggestRectangle(rectangles);

        Console.WriteLine("\nBiggest Rectangle:");
        Console.WriteLine(biggestRectangle);

        Console.ReadKey();
    }

    static Rectangle FindBiggestRectangle(Rectangle[] rectangles)
    {
        if (rectangles == null || rectangles.Length == 0)
        {
            return null;
        }

        Rectangle biggest = rectangles[0];
        for (int i = 1; i < rectangles.Length; i++)
        {
            if (rectangles[i].CalculateArea() > biggest.CalculateArea())
            {
                biggest = rectangles[i];
            }
        }

        return biggest;
    }
}