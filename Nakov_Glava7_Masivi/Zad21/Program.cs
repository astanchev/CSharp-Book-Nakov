using System;

namespace Zad21
{
    class Program
    {
        public static int[] GetSubsetWithSumAndSize(int[] a, bool[] filter, int index, int s, int size)
        {
            if (index < a.Length)
            {
                filter[index] = true;
                int[] x = GetSubsetWithSumAndSize(a, filter, index + 1, s, size);

                if (x.Length > 0)
                {
                    return x;
                }
                else
                {
                    filter[index] = false;
                    return GetSubsetWithSumAndSize(a, filter, index + 1, s, size);
                }
            }
            else
            {
                int sum = 0, count = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (filter[i])
                    {
                        sum += a[i];
                        count++;
                    }
                }

                int[] solution = new int[0];
                if (sum == s && count == size)
                {
                    solution = new int[count];
                    count = 0;
                    for (int i = 0; i < a.Length; i++)
                    {
                        if (filter[i])
                        {
                            solution[count++] = a[i];
                        }
                    }
                }
                return solution;
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Number of elements, n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Size of the subset, size = ");
            int size = int.Parse(Console.ReadLine());

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

            Console.Write("Sum of elements, s = ");
            int s = int.Parse(Console.ReadLine());

            int[] solution = GetSubsetWithSumAndSize(a, new bool[a.Length], 0, s, size);

            Console.WriteLine("Your solution:");
            for (int i = 0; i < solution.Length; i++)
            {
                Console.Write(solution[i] + "; ");
            }
        }
    }
}
