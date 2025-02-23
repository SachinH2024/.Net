using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPatternFileFolderHierarchyApp.Models
{
    public class File : IFileSystemItem
    {
        private string _name;

        public File(string name)
        {
            _name = name;
        }
        public void Display(List<string> results, int depth)
        {
            results.Add(new string('-', depth) + " " + _name);
        }
    }
}