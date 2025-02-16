using CompositeDesignPatternApp.Models;

namespace CompositeDesignPatternApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEmployee emp1 = new Employee("Deepa", "Developer");
            IEmployee emp2 = new Employee("Minu", "Designer");
            IEmployee emp3 = new Employee("Mathi", "Tester");


            Manager manager1 = new Manager("Markonda", "Development Manager");
            Manager manager2 = new Manager("Sachin", "Project Manager");


            manager1.AddSubordinate(emp1);
            manager1.AddSubordinate(emp2);

            manager2.AddSubordinate(manager1);
            manager2.AddSubordinate(emp3);


            Console.WriteLine(manager2.GetEmployeeDetails());
        }
    }
}