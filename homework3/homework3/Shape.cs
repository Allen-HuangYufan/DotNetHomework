using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    abstract class Shape:IArea
    {
        public abstract bool IsLegal();

        public abstract double Area();
    }
}
