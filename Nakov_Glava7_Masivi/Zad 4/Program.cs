using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int tempCount = 1;
            int number = 0;

            Console.WriteLine("Enter the array lenght: ");
            int lenght = int.Parse(Console.ReadLine());

            int[] array = new int[lenght];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter {i} element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    tempCount++;
                }
                else
                {
                    tempCount = 1;
                }

                if (tempCount > count)
                {
                    count = tempCount;
                    number = i;
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{array[number]} ");
            }
        }
    }
}
