using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPatternApp.Models
{
    public class Manager : IEmployee
    {
        private string _name;
        private string _position;
        private List<IEmployee> _subordinates;

        public Manager(string name, string position)
        {
            _name = name;
            _position = position;
            _subordinates = new List<IEmployee>();
        }

        public void AddSubordinate(IEmployee employee)
        {
            _subordinates.Add(employee);
        }

        public void RemoveSubordinate(IEmployee employee)
        {
            _subordinates.Remove(employee);
        }

        public string GetEmployeeDetails(int indentationLevel = 0)
        {
            string indentation = new string(' ', indentationLevel * 2); // 2 spaces per level
            string details = $"{indentation}{_name} works as {_position}";
            foreach (var employee in _subordinates)
            {
                details += $"\n{employee.GetEmployeeDetails(indentationLevel + 1)}";
            }
            return details;
        }
    }

}