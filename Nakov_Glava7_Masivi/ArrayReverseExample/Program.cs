using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReverseExample
{
    class Program
    {
        static void Main(string[] args)
        {            
            int lenght = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int[] reversed = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                reversed[(lenght - 1) - i] = array[i];
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < lenght; i++)
            {
                Console.Write(reversed[i]+" ");
            }
            Console.WriteLine();

            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine($"{i} = {reversed[i]}");
            }
        }
    }
}
