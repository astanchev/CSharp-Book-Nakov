using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simetric_Massives
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer: ");
            int lenght = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];

            Console.WriteLine("Enter the values of the array: ");

            for (int i = 0; i < lenght; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            bool symetric = true;

            for (int i = 0; i < array.Length/2; i++)
            {
                if (array[i] != array[(lenght-1)-i])
                {
                    symetric = false;
                    break;
                }
            }
            Console.WriteLine($"Is symetric? {symetric}");
        }
    }
}
