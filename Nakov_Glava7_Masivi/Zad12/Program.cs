using System;

namespace Zad12_a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter columns: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = (i + 1) + j * rows;
                    Console.Write($"{matrix[i, j],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
