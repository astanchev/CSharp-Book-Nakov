using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter lenght of first array: ");
            int lenght1 = int.Parse(Console.ReadLine());
            int[] firstArray = new int[lenght1];


            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"Enter element {i}: ");
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter lenght of second array: ");
            int lenght2 = int.Parse(Console.ReadLine());

            if (lenght1!=lenght2)
            {
                Console.WriteLine("The lenght of the two arrays is not equal.");
            }
            else
            {
                int[] secondArray = new int[lenght1];
                for (int i = 0; i < secondArray.Length; i++)
                {
                    Console.Write($"Enter element {i}: ");
                    secondArray[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < secondArray.Length; i++)
                {
                    if (firstArray[i]!=secondArray[i])
                    {
                        Console.WriteLine($"The arrays are different.");
                        return;
                    }                    
                }
                Console.WriteLine("The arrays are equal.");
            }
        }
    }
}
