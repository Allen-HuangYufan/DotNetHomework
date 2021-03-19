using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("begin creating random shapes");
            Console.WriteLine();
            Random random = new Random();
            string[] shapeType = { "Rectangle", "Square", "Triangle" };
            double areaSum = 0;
            for (int i = 0; i < 10; i++)
            {
                string shapeName = shapeType[random.Next(0, 3)];
                Console.WriteLine(shapeName);
                Shape product = ShapeFactory.Create(shapeName);
                if (product == null) i--;
                else areaSum += product.Area();
            }
            Console.WriteLine("total area of these 10 shapes is: " + areaSum.ToString());
        }
    }
}
