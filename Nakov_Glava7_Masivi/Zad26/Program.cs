using System;

namespace Zad26
{
    class Program
    {
        public static int GetSizeOfArea(int[,] a, int i, int j,
                                    bool[,] visited)
        {
            int up, down, left, right;
            up = down = left = right = 0;

            visited[i, j] = true;

            if (i > 0
                && !visited[i - 1, j] && a[i, j] == a[i - 1, j])
            {
                up = GetSizeOfArea(a, i - 1, j, visited);
            }
            if (i + 1 < a.GetLength(0)
                && !visited[i + 1, j] && a[i, j] == a[i + 1, j])
            {
                down = GetSizeOfArea(a, i + 1, j, visited);
            }
            if (j > 0
                && !visited[i, j - 1] && a[i, j] == a[i, j - 1])
            {
                left = GetSizeOfArea(a, i, j - 1, visited);
            }
            if (j + 1 < a.GetLength(1)
                && !visited[i, j + 1] && a[i, j] == a[i, j + 1])
            {
                right = GetSizeOfArea(a, i, j + 1, visited);
            }

            return 1 + up + down + left + right;
        }
        static void Main(string[] args)
        {
            Console.Write("Number of rows, m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Number of columns, n = ");
            int n = int.Parse(Console.ReadLine());

            int[,] a = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0}, {1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Your matrix is as follows:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0, 4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            bool[,] visited = new bool[m, n];
            int maxSize = 1, val = a[0, 0], size = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!visited[i, j])
                    {
                        size = GetSizeOfArea(a, i, j, visited);
                        if (size > maxSize)
                        {
                            maxSize = size;
                            val = a[i, j];
                        }
                    }
                }
            }

            Console.WriteLine("Value: {0}, size: {1}.", val, maxSize);
        }
    }
    
}
