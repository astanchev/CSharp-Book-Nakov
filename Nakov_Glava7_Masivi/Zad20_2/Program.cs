using System;

namespace Zad20_2
{
    class Program
    {
        public static int[] GetSubsetWithSum(int[] a, bool[] filter, int index, int s)
        {
            if (index < a.Length)
            {
                filter[index] = true;
                int[] x = GetSubsetWithSum(a, filter, index + 1, s);

                if (x.Length > 0)
                {
                    return x;
                }
                else
                {
                    filter[index] = false;
                    return GetSubsetWithSum(a, filter, index + 1, s);
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
                if (sum == s)
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

            int[] solution = GetSubsetWithSum(a, new bool[a.Length], 0, s);

            Console.WriteLine("Your solution:");
            for (int i = 0; i < solution.Length; i++)
            {
                Console.Write(solution[i] + "; ");
            }
        }
    }
}
