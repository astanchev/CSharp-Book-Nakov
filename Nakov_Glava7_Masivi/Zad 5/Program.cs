using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array lenght: ");
            int lenght = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];

            int sames = 1;
            int bestSames = 1;
            int bestStart = 0;
            int lastElement = 0;


            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter {i} element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + 1 == array[i + 1])
                {
                    sames++;
                    if (sames > bestSames)
                    {
                        bestSames = sames;
                        lastElement = i + 1;
                        bestStart = lastElement - bestSames + 1;
                    }                    
                }
                else
                {
                    sames = 1;
                }
            }
            Console.WriteLine();
            for (int i = bestStart; i < bestStart + bestSames; i++)
            {
                Console.Write($"{array[i]} ");
            }


        }
    }
}
