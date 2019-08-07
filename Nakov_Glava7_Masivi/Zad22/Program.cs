using System;

namespace Zad22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                int[] a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("a[{0}] = ", i);
                    a[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Your array:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(a[i] + "; ");
                }
                Console.WriteLine();

                int m = (1 << n);
                int[,] subsets = new int[m, n];

                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        subsets[i, j] = i / (m / 2 / (1 << j)) % 2;
                    }
                }

                int bestSubset = 0, bestLength = 0;
                for (int i = 0; i < m; i++)
                {
                    int max = int.MinValue, count = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (subsets[i, j] > 0)
                        {
                            if (a[j] >= max)
                            {
                                count++;
                                max = a[j];
                            }
                            else
                            {
                                count = 0;
                                break;
                            }
                        }
                    }
                    if (bestLength < count)
                    {
                        bestLength = count;
                        bestSubset = i;
                    }
                }

                Console.WriteLine("Your solution:");
                for (int i = 0; i < n; i++)
                {
                    if (subsets[bestSubset, i] > 0)
                    {
                        Console.Write(a[i] + "; ");
                    }
                }
                Console.WriteLine();

            }
            else
            {
                Console.WriteLine("Invalid data! Let n > 0.");
            }
        }

    }
}
