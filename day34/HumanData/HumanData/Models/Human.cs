using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanData.Models
{
    public class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; } // Height in meters
        public double Weight { get; set; } // Weight in kilograms
        public string Gender { get; set; }

        public Human(string name, int age, double height, double weight, string gender)
        {
            Name = name;
            Age = age;
            Height = height;
            Weight = weight;
            Gender = gender;
        }

        public void Eat()
        {
            Weight *= 1.10; // Increase weight by 10%
        }

        public void Workout()
        {
            Weight *= 0.95; // Decrease weight by 5%
            Height *= 1.02; // Increase height by 2%
        }

        public double CalculateBMI()
        {
            return Weight / (Height * Height);
        }

        public string GetBodyStructure()
        {
            double bmi = CalculateBMI();
            if (bmi < 18.5) return "Underweight";
            if (bmi < 25) return "Normal weight";
            if (bmi < 30) return "Overweight";
            return "Obese";
        }
    }
}
