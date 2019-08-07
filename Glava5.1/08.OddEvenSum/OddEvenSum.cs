using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += number;
                }
                else
                {
                    sumOdd += number;
                }
            }


            if (sumEven == sumOdd)
            {
                Console.WriteLine($"Yes, Sum = {sumEven}");
            }
            else
            {
                Console.WriteLine($"No, Diff = {Math.Abs(sumEven - sumOdd)}");
            }
        }
    }
}
