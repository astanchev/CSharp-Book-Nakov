using System;

namespace Zad25
{
    class Program
    {
        public void PrintCombinations(int[] selected,
                                        int[] available,
                                        int k)
        {
            if (k == 0)
            {
                for (int j = 0; j < selected.Length; j++)
                {
                    Console.Write("{0,3}", selected[j]);
                }
                Console.WriteLine();
            }
            else if (available.Length == k)
            {
                for (int j = 0; j < selected.Length; j++)
                {
                    Console.Write("{0,3}", selected[j]);
                }
                for (int j = 0; j < available.Length; j++)
                {
                    Console.Write("{0,3}", available[j]);
                }
                Console.WriteLine();
            }
            else if (available.Length > k)
            {
                int[] newSelected = new int[selected.Length + 1];
                int[] newAvailable = new int[available.Length - 1];
                for (int j = 0; j < selected.Length; j++)
                {
                    newSelected[j] = selected[j];
                }
                newSelected[selected.Length] = available[0];
                for (int j = 1; j < available.Length; j++)
                {
                    newAvailable[j - 1] = available[j];
                }
                PrintCombinations(newSelected, newAvailable, k - 1);

                PrintCombinations(selected, newAvailable, k);
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            if (1 <= k && k <= n)
            {
                int variations = 1;
                for (int i = n; i > n - k; i--)
                {
                    variations *= i;
                }
                Console.WriteLine("Variations = " + variations);
                int combinations = variations;
                for (int i = k; i > 0; i--)
                {
                    combinations /= i;
                }
                Console.WriteLine("Combinations = " + combinations);

                int[] availableElements = new int[n];
                for (int i = 0; i < n; i++)
                {
                    availableElements[i] = i + 1;
                }

                PrintCombinations(new int[0], availableElements[], k);
            }
            else
            {
                Console.WriteLine(
                   "Invalid data! Let 1 <= k <= n.");
            }
        }
    }
}
