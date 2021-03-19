using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    class ShapeFactory
    {
        public static Shape Create(string shapeType)
        {
            if (shapeType == null) return null;
            switch(shapeType)
            {
                case "Rectangle":
                    Console.WriteLine("please input the length");
                    string lengthStr = Console.ReadLine();
                    Console.WriteLine("please input the width");
                    string widthStr = Console.ReadLine();
                    double length, width;
                    if (!Double.TryParse(lengthStr, out length) || !Double.TryParse(widthStr, out width))
                    {
                        Console.WriteLine("illegal input!");
                        return null;
                    }
                    else return new Rectangle(length, width);
                    break;
                case "Square":
                    Console.WriteLine("please input the a");
                    string aStr = Console.ReadLine();
                    double a;
                    if (!Double.TryParse(aStr, out a))
                    {
                        Console.WriteLine("illegal input!");
                        return null;
                    }
                    else return new Square(a);
                    break;
                case "Triangle":
                    Console.WriteLine("please input edgeA");
                    string edgeStrA = Console.ReadLine();
                    Console.WriteLine("please input edgeB");
                    string edgeStrB = Console.ReadLine();
                    Console.WriteLine("please input edgeC");
                    string edgeStrC = Console.ReadLine();
                    double edgeA, edgeB, edgeC;
                    if (!Double.TryParse(edgeStrA, out edgeA) || !Double.TryParse(edgeStrB, out edgeB) || !Double.TryParse(edgeStrC, out edgeC))
                    {
                        Console.WriteLine("illegal input!");
                        return null;
                    }
                    else return new Triangle(edgeA, edgeB, edgeC);
                    break;
                default:
                    return null;
            }

        }
    }
}
