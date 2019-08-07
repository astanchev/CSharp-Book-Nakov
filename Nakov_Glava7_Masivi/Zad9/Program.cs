using System;

namespace Zad9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array lenght: ");
            int lenghtArray = int.Parse(Console.ReadLine());
            int[] array = new int[lenghtArray];
            int maxSum = 0;
            int start = 0;
            int end = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter {i} element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length-1; i++)
            {
                int sum = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    sum += array[j];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        start = i;
                        end = j;
                    }
                }
            }
            Console.WriteLine();
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"The sum is: {maxSum}");

        }
    }
}
