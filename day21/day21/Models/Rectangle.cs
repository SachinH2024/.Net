using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day21.Models
{
    class Rectangle
    {
        public int height;
        public int width;
        public int CalculatedArea()
        {
            return height * width;
        }
    }
}
