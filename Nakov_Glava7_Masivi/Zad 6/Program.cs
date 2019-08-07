using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array lenght: ");
            int lenght = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];
            int[] result = new int[lenght]; ;
            int tempIndex, tempCounter;
            int counter = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter {i} element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < lenght; i++)
            {
                tempIndex = 1;
                tempCounter = 1;
                int[] tempArray = new int[lenght];
                tempArray[0] = array[i];

                for (int j = i + 1; j < lenght; j++)
                {
                    if (array[j] > tempArray[tempIndex - 1])
                    {
                        tempArray[tempIndex] = array[j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && array[j] < tempArray[tempIndex - 1] && array[j] > tempArray[tempIndex - 2])
                    {
                        tempArray[tempIndex - 1] = array[j];
                    }
                    if (tempCounter > counter)
                    {
                        counter = tempCounter;
                        result = tempArray;
                    }
                }
            }

            for (int i = 0; i < counter; i++)
            {
                Console.Write($"{result[i]}, ");
            }

        }
    }
}
