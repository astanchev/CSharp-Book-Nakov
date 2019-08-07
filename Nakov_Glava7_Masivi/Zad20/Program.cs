using System;

namespace Zad20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array length: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter S: ");
            int wantedSum = int.Parse(Console.ReadLine());

            int[] subset = new int[length];
            bool solution = false;

            for (int i = 1; i <= length; i++)
            {

            }



        }
    }
}
