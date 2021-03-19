using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Triangle:Shape
    {
        private double edgeA;
        private double edgeB;
        private double edgeC;

        public Triangle(double edgeA,double edgeB,double edgeC)
        {
            this.edgeA = edgeA;
            this.edgeB = edgeB;
            this.edgeC = edgeC;
        }
        public override bool IsLegal()
        {
            return ((edgeA + edgeB > edgeC) && (edgeA + edgeC > edgeB) && (edgeB + edgeC > edgeA));
        }

        public override double Area()
        {
            double p = (edgeA + edgeB + edgeC) / 2;
            return System.Math.Sqrt(p * (p - edgeA) * (p - edgeB) * (p - edgeC));
        }
    }
}
