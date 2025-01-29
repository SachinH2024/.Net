using System;
using System.IO;

namespace UserDataApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Username: ");
            string username = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            string address= Console.ReadLine();

            string filepath = "C:\\.Net\\.Net\\day32\\UserDataApp\\Test.txt";

            using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs)) 
                { 
                    sw.WriteLine($"Username : {username}");
                    sw.WriteLine($"Address  : {address}");
                }
            }

            Console.WriteLine("User data saved to " + filepath);
        }
    }
}
