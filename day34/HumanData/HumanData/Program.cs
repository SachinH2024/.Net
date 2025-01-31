using HumanData.Models;
using System.Collections;

namespace HumanData
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList humans= new ArrayList();
            //List<Human> humans = new List<Human>();

            // Create Human instances

            
            humans.Add(new Human("Alice", 30, 1.70, 65, "Female"));
            humans.Add(new Human("Bob", 25, 1.80, 80, "Male"));
            humans.Add(new Human("Charlie", 35, 1.65, 70, "Male"));

            // Perform actions and display data
            foreach (Human human in humans)
            {
                Console.WriteLine($"Name: {human.Name}, Age: {human.Age}, Gender: {human.Gender}");
                Console.WriteLine($"Height: {human.Height:F2} m, Weight: {human.Weight:F2} kg");

                human.Eat();
                Console.WriteLine("After Eating: ");
                Console.WriteLine($"Height: {human.Height:F2} m, Weight: {human.Weight:F2} kg");

                human.Workout();
                Console.WriteLine("After Workout: ");
                Console.WriteLine($"Height: {human.Height:F2} m, Weight: {human.Weight:F2} kg");

                double bmi = human.CalculateBMI();
                string bodyStructure = human.GetBodyStructure();
                Console.WriteLine($"BMI: {bmi:F2}, Body Structure: {bodyStructure}");
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
