using System;

namespace Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array lenght: ");
            int lenghtArray = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the max sum lenght: ");
            int lenghtMaxSum = int.Parse(Console.ReadLine());
            int[] array = new int[lenghtArray];
            int maxSum = 0;
            int start = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter {i} element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - lenghtMaxSum; i++)
            {
                int sum = 0;
                for (int j = i; j < i + lenghtMaxSum; j++)
                {
                    sum += array[j];
                }
                if (sum > maxSum)
                {
                    maxSum = sum;
                    start = i;
                }
            }

            for (int i = start; i < start + lenghtMaxSum; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine(maxSum);
        }
    }
}
