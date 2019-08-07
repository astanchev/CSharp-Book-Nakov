using System;

namespace Zad13
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

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"Enter [{row}, {column}] element: ");
                    matrix[row, column] = int.Parse(Console.ReadLine());
                }
            }

            int bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            Console.WriteLine("The best platform 3x3 is:");
            Console.WriteLine($" {matrix[bestRow, bestCol]} {matrix[bestRow, bestCol + 1]} {matrix[bestRow, bestCol + 2]}");
            Console.WriteLine($" {matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]} {matrix[bestRow + 1, bestCol + 2]}");
            Console.WriteLine($" {matrix[bestRow + 2, bestCol]} {matrix[bestRow + 2, bestCol + 1]} {matrix[bestRow + 2, bestCol + 2]}");
            Console.WriteLine($"The maximal sum is: {bestSum}");
        }
    }
}
