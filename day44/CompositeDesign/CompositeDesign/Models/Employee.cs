using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPatternApp.Models
{
    public class Employee : IEmployee
    {
        private string _name;
        private string _position;

        public Employee(string name, string position)
        {
            _name = name;
            _position = position;
        }

        public string GetEmployeeDetails(int indentationLevel = 0)
        {
            string indentation = new string(' ', indentationLevel * 2); // 2 spaces per level
            return $"{indentation}{_name} works as {_position}";
        }
    }
}