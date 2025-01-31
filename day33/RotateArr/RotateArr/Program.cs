using System;
using System.Collections.Generic;


namespace RotateArr
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10, 20, 30, 40 };

            List<int> rotatedList=RotetElements(myList);

            Console.WriteLine(string.Join(",",rotatedList));

        }

        public static List<int> RotetElements(List<int> lst)
        {
            if (lst.Count == 0)
            {
                return new List<int>();
            }

            List<int> rotateList = new List<int>();

            for (int i = 1; i < lst.Count; i++) 
            {
                rotateList.Add(lst[i]);
               
            }

            rotateList.Add(lst[0]);
            return rotateList;
        }
    }
}
