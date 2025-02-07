using System;
using System.IO;



namespace ImageBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imagePath = @"C:\.Net\.Net\day39\Tiger.jpg";
            string outputImagePath = @"C:\.Net\.Net\day39\ReduceTigerBinary.jpg";

            
            byte[] imageBytes = File.ReadAllBytes(imagePath);

            int halfLength=imageBytes.Length / 2;

            byte[] halfImagebytes = new byte[halfLength];

            Array.Copy(imageBytes,halfImagebytes,halfLength);


            File.WriteAllBytes(outputImagePath, halfImagebytes);

        }
    }
}
