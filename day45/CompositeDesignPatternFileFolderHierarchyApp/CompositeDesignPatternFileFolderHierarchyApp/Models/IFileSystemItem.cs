using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPatternFileFolderHierarchyApp.Models
{
    public interface IFileSystemItem
    {
        void Display(List<string> results, int depth);
    }
}