using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j>1)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(number);
                    number++;
                    if (number>n)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
