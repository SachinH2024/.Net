using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPatternFileFolderHierarchyApp.Models
{
    public class Folder : IFileSystemItem
    {
        private string _name;
        private List<IFileSystemItem> _children = new List<IFileSystemItem>();

        public Folder(string name)
        {
            _name = name;
        }

        public void Add(IFileSystemItem item)
        {
            _children.Add(item);
        }

        public void Remove(IFileSystemItem item)
        {
            _children.Remove(item);
        }

        public void Display(List<string> results, int depth)
        {
            results.Add(new string('-', depth) + " " + _name);

            foreach (IFileSystemItem item in _children)
            {
                item.Display(results, depth + 2);
            }
        }
    }
}