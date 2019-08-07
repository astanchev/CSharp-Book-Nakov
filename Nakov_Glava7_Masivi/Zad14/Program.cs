using System;

namespace Zad14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter columns: ");
            int columns = int.Parse(Console.ReadLine());

            string[,] matrix = new string[rows, columns];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"Enter [{row}, {column}] element: ");
                    matrix[row, column] = Console.ReadLine();
                }
            }

            //Отпечатване на матрицата за по-лесно сравняване на резултата
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    Console.Write($"{matrix[row, column],5} ");
                }
                Console.WriteLine();
            }



            int tempSequence = 1;
            int sequence = 1;
            string element = string.Empty;

            //Търсене на най-дълга последователност по редове
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1) - 1; column++)
                {
                    if (matrix[row, column] == matrix[row, column + 1]) tempSequence++;
                    else tempSequence = 1;

                    if (sequence < tempSequence)
                    {
                        sequence = tempSequence;
                        element = matrix[row, column];
                    }
                }
                tempSequence = 1;
            }

            //Търсене на най-дълга последователност по колони
            for (int column = 0; column < matrix.GetLength(1); column++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, column] == matrix[row + 1, column]) tempSequence++;
                    else tempSequence = 1;

                    if (sequence < tempSequence)
                    {
                        sequence = tempSequence;
                        element = matrix[row, column];
                    }
                }
                tempSequence = 1;
            }

            //Търсене на най-дълга последователност по диагонали отляво-надясно
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)//Реда от който започва диагонала
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)//Колоната от която започва диагонала
                {
                    for (int row = i, column = j; row < matrix.GetLength(0) - 1 && column < matrix.GetLength(1) - 1; row++, column++)//Проследяване на диагонала от горе до долу и надясно
                    {
                        if (matrix[row, column] == matrix[row + 1, column + 1]) tempSequence++;
                        else tempSequence = 1;

                        if (sequence < tempSequence)
                        {
                            sequence = tempSequence;
                            element = matrix[row, column];
                        }
                    }
                    tempSequence = 1;
                }

            //Търсене на най-дълга последователност по диагонали отдясно-наляво
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)//Реда от който започва диагонала 
                for (int j = 1; j < matrix.GetLength(1); j++)//Колоната от която започва диагонала  
                {
                    for (int row = i, column = j; row < matrix.GetLength(0) - 1 && column > 0; row++, column--)//Проследяване на диагонала от горе до долу и наляво (колоната се движи от ляво надясно)
                    {
                        if (matrix[row, column] == matrix[row + 1, column - 1]) tempSequence++;
                        else tempSequence = 1;

                        if (sequence < tempSequence)
                        {
                            sequence = tempSequence;
                            element = matrix[row, column];
                        }
                    }
                    tempSequence = 1;
                }

            for (int i = 0; i < sequence; i++) Console.Write("{0}, ", element);

        }
    }
}
