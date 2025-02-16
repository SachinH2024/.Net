using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Node
{
    public class Nodee<T>
    {
        public T Data { get; set; }
        public Nodee<T> Next { get; set; }

        public Nodee(T data)
        {
            Data = data;
            Next = null; // Initially, the next node is null
        }
    }
}
