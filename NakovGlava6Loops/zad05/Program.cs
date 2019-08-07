using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 1;
            Console.Write(firstNumber + " " + secondNumber + " ");
            for (int i = 1; i <= n; i++)
            {
                int fibonachi = firstNumber + secondNumber;
                if (fibonachi >= n)
                {
                    break;
                }
                Console.Write(fibonachi + " ");
                firstNumber = secondNumber;
                secondNumber = fibonachi;
            }
        }
    }
}
