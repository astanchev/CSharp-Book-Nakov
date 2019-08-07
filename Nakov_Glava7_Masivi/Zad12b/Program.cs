using System;

namespace Zad12b
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

            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                if (column % 2 != 0)
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        int prevColumn = matrix[0, column - 1];
                        matrix[row, column] = prevColumn + (2 * rows - 1) - row;
                    }
                }
                else
                {
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        matrix[row, column] = row + column * rows + 1;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"{matrix[row, column],3} ");
                }
                Console.WriteLine();
            }
        }
    }
}
