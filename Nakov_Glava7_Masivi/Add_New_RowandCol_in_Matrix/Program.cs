using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_New_RowandCol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 5, 7, 8 }, { 5, 6, 9}, {1, 3, 7 }, { 2, 4, 6} };

            Console.WriteLine("Old array:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }

            Random rnd = new Random();

            int row = rnd.Next(matrix.GetLength(0) + 1);
            int col = rnd.Next(matrix.GetLength(1) + 1);

            Console.WriteLine($"Adding {row}-th row and {col}-th column.");

            int[,] tmp = new int[matrix.GetLength(0) + 1, matrix.GetLength(1) + 1];
            int a = 0;
            int b = 0;
            int c = 15;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (i<row) a = i;
                else a = i + 1;
            
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j < col) b = j;
                    else b = j + 1;

                    tmp[a, b] = matrix[i, j];
                }
            }

            for (int i = 0; i < tmp.GetLength(0); i++)
            {
                for (int j = 0; j < tmp.GetLength(1); j++)
                {
                    Console.Write(tmp[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int j = 0; j < tmp.GetLength(1); j++)
            {
                tmp[row, j] = c;
                c++;
            }

            for (int i = 0; i < tmp.GetLength(1); i++)
            {
                if (i!=row)
                {
                    tmp[i, col] = c;
                    c++;
                }
            }

            matrix = tmp;
            Console.WriteLine("New array:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
