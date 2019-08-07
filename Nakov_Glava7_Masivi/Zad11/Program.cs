using System;

namespace Zad11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array lenght: ");
            int lenghtArray = int.Parse(Console.ReadLine());
            int[] array = new int[lenghtArray];
            Console.Write("Enter the sum: ");
            int sum = int.Parse(Console.ReadLine());
            int start = 0;
            int end = 0;
            bool sumFound = false;
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter {i} element: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                int tempSum = array[i];
                if (tempSum==sum)
                {
                    Console.WriteLine($"The sum: {sum} is equal to element {i}: {array[i]}");
                    return;
                }
                for (int j = i + 1; j < array.Length; j++)
                {
                    tempSum += array[j];
                    if (tempSum==sum)
                    {
                        start = i;
                        end = j;
                        sumFound = true;
                        break;
                    }
                    else if (tempSum>sum)
                    {
                        break;
                    }
                }
                if (sumFound)
                {
                    break;
                }
            }

            Console.WriteLine();
            if (sumFound)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.Write($"{array[i]} ");
                }
            }
            else
            {
                Console.WriteLine("No sum found!");
            }


        }
    }
}
