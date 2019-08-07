using System;

namespace Zad8_Bubbles_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array lenght: ");
            int lenghtArray = int.Parse(Console.ReadLine());
            int[] array = new int[lenghtArray];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Enter {i} element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length-1; i++)
            {
                for (int j = 0; j < array.Length-i; j++)
                {
                    if (array[j]>array[j+1])
                    {
                        int a = array[j+1];
                        array[j + 1] = array[j];
                        array[j] = a;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }


        }
    }
}
