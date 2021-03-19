using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Square:Shape
    {
        private double a;

        public Square(double a)
        {
            this.a = a;
        }

        public override bool IsLegal()
        {
            return (a > 0);
        }

        public override double Area()
        {
            return a * a;
        }
    }
}
