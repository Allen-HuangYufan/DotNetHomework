using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkNode
{
    class Program
    {
        static int max, min, sum;
        static void Max(int x)
        {
            max = max > x ? max : x;
        }

        static void Min(int x)
        {
            min = min < x ? min : x;
        }

        static void Sum(int x)
        {
            sum += x;
        }

        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(random.Next(1, 100));
            }
            max = min = list.Head.Data;

            Console.WriteLine("print LinkNode");
            list.ForEach((x) => Console.Write(x.ToString() + " "));
            Console.WriteLine();
            Console.WriteLine("get max");
            list.ForEach((x) => Max(x));
            Console.WriteLine(max.ToString());
            Console.WriteLine("get min");
            list.ForEach((x) => Min(x));
            Console.WriteLine(min.ToString());
            Console.WriteLine("get sum");
            list.ForEach((x) => Sum(x));
            Console.WriteLine(sum.ToString());
        }
    }
}
