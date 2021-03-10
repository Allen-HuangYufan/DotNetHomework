using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input M:");
            int M = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input N:");
            int N = Int32.Parse(Console.ReadLine());
            Console.WriteLine("input the matrix:");
            int[,] matrix = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                string str = Console.ReadLine();
                string[] temp = str.Split(' ');
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = Int32.Parse(temp[j]);
                }
            }
            if (JudgeMatrix(matrix)) Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
        static bool JudgeMatrix(int[,] matrix)
        {
            int x = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j && x != matrix[i, j]) return false;
                }
            }
            return true;
        }
    }
}
