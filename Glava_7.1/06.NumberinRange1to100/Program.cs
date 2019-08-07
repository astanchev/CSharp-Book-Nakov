using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumberinRange1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (true)
            {
                if (n >= 1 && n <= 100)
                {
                    Console.WriteLine($"The number is {n}");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                    n = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
