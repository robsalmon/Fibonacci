using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public override int Perimeter()
        {
            return (Height + Width) * 2;
        }
    }
}
