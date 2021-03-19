using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Rectangle:Shape
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override bool IsLegal()
        {
            return (length > 0 && width > 0);
        }

        public override double Area()
        {
            return length * width;
        }
    }
}
