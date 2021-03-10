using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number");
            int num;
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("All prime factor:");
            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0 && JudgePrime(i))
                    Console.Write(i + " ");
            }
        }

        static bool JudgePrime(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i < x; i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
    }
}
