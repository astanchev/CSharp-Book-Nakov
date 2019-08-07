using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int output = input; 

            int number = input;
            int thirdDigit = number % 10;
            number /= 10;
            int secondDigit = number % 10;
            int firstDigit = number / 10;

            int row = firstDigit + secondDigit;
            int col = firstDigit + thirdDigit;

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (output%5==0)
                    {
                        output -= firstDigit;
                    }
                    else if (output%3==0)
                    {
                        output -= secondDigit;
                    }
                    else
                    {
                        output += thirdDigit;
                    }
                    Console.Write($"{output} ");
                }
                Console.WriteLine();
            }
        }
    }
}
