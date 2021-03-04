using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            string str;
            str = Console.ReadLine();

            switch (str)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a + b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                case "%":
                    Console.WriteLine($"{a} % {b} = {a % b}");
                    break;
                default:
                    Console.WriteLine("input error");
                    break;
            }
        }
    }
}
