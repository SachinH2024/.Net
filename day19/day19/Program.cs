using System;

class RecursiveName
{
    static void Main()
    {
        PrintNameRecursive("Sachin Hulawale", 10);
    }

    static void PrintNameRecursive(string name, int count)
    {
        if (count > 0)
        {
            Console.WriteLine(name);
            PrintNameRecursive(name, count-1);
        }


    }
}