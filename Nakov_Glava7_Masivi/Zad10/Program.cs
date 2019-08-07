using System;

namespace Zad10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the array lenght: ");
            int lenghtArray = int.Parse(Console.ReadLine());
            int[] array = new int[lenghtArray];
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter {i} element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxCounter = 1;
            int number = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        number = array[i];
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"The number {number} appears {maxCounter} times.");
        }
    }
}
