using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.NumberTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int number = 1;

            for (int row = 0; row < input; row++)
            {                
                for (int col = 0; col < input; col++)
                {
                    number = row + col + 1;
                    if (number>input)
                    {
                        number = 2*input-number;
                    }
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}
