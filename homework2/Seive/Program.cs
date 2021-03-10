using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seive
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[99];
            for (int i = 0; i < 99; i++)
            {
                array[i] = i + 2;
            }
            for (int j = 2; j < 11; j++)
            {
                for (int i = 0; i < 99; i++)
                {
                    if (array[i] != 0 && array[i] % j == 0 && array[i] != j) array[i] = 0;
                }
            }
            for (int i = 0; i < 99; i++)
            {
                if (array[i] != 0) Console.Write(array[i] + " ");
            }
        }
    }
}
