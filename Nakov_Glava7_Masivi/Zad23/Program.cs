using System;

namespace Zad23
{
    class Program
    {
        static void recSolution(int[] array, int index)
        {
            if (index != array.Length)
                for (int i = 1; i <= n; i++)
                {
                    array[index] = i;
                    recSolution(array, index + 1);
                }
            else
            {
                for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[k];

            recSolution(arr, 0);
        }
    }
}
