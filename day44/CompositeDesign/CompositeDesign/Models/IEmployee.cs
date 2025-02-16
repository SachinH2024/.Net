using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPatternApp.Models
{
    public interface IEmployee
    {
        string GetEmployeeDetails(int indentationLevel = 0);
    }
}