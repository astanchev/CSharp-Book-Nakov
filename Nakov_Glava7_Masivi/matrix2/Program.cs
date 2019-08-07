using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the number of rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the number of columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter the cells of the matrix:");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" "+ matrix[row,col]);
                }
                Console.WriteLine();
            }            
        }
    }
}
