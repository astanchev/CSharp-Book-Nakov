using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Crossingsequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int tribonacciFirst = int.Parse(Console.ReadLine());
            int tribonacciSecond = int.Parse(Console.ReadLine());
            int tribonacciThird = int.Parse(Console.ReadLine());
            int spiralCurrent = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int tribonacciCurrent = tribonacciFirst + tribonacciSecond + tribonacciThird;
            int spiralMultiplier = 1;
            int spiralIncrement = 0;

            while (tribonacciCurrent <= 1000000 && spiralCurrent <= 1000000)
            {
                if (spiralCurrent == tribonacciFirst || spiralCurrent == tribonacciSecond || spiralCurrent == tribonacciThird || spiralCurrent == tribonacciCurrent)
                {
                    Console.WriteLine(spiralCurrent);
                    return;
                }
                else if (tribonacciCurrent < spiralCurrent)
                {

                    tribonacciFirst = tribonacciSecond;
                    tribonacciSecond = tribonacciThird;
                    tribonacciThird = tribonacciCurrent;
                    tribonacciCurrent = tribonacciFirst + tribonacciSecond + tribonacciThird;
                }
                else
                {
                    spiralCurrent += spiralMultiplier * step;
                    spiralIncrement++;
                    if (spiralIncrement == 2)
                    {
                        spiralMultiplier++;
                        spiralIncrement = 0;
                    }
                }
            }
            Console.WriteLine("No");
        }
    }
}
