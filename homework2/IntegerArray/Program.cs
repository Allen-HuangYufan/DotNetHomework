using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 22, 333, 4444, 55555 };
            Console.WriteLine("Maximum:");
            Console.WriteLine(GetMaximum(array));
            Console.WriteLine("Minimum:");
            Console.WriteLine(GetMinimum(array));
            Console.WriteLine("Average:");
            Console.WriteLine(GetAverage(array));
            Console.WriteLine("Sum:");
            Console.WriteLine(GetSum(array));
        }

        static int GetMaximum(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < 5; i++)
            {
                if (array[i] >= max) max = array[i];
            }
            return max;
        }
        static int GetMinimum(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < 5; i++)
            {
                if (array[i] <= min) min = array[i];
            }
            return min;
        }

        static int GetAverage(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += array[i];
            }
            return sum / 5;
        }

        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
