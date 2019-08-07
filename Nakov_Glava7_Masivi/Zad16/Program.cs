using System;

namespace Zad16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int arrayLength = int.Parse(Console.ReadLine());

            int[] array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Index {0} -> ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            Array.Sort(array);
            int left = 0;
            int right = array.Length - 1;
            int middle = 0;
            int index = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                middle = (left + right) / 2;

                if (number == array[middle])
                {
                    index = middle;
                    Console.WriteLine("The number index is: {0}", index);
                    break;
                }
                else if (number < array[middle])
                {
                    right = middle - 1;
                }
                else if (number > array[middle])
                {
                    left = middle + 1;
                }
            }
            if (index != middle)
            {
                Console.WriteLine("There is no such number in the array!!!");
            }
        }
    }
}
