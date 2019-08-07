using System;

namespace Zad8_2_Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallestIndex, index, minIndex, temp;

            Console.WriteLine("Enter the array lenght: ");
            int lenghtArray = int.Parse(Console.ReadLine());
            int[] array = new int[lenghtArray];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter {i} element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (index = 0; index < array.Length - 1; index++)
            {
                smallestIndex = index;
                for (minIndex = index; minIndex < array.Length; minIndex++)
                {
                    if (array[minIndex] < array[smallestIndex])
                    {
                        smallestIndex = minIndex;
                    }
                }
                temp = array[smallestIndex];
                array[smallestIndex] = array[index];
                array[index] = temp;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}