using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int maxDiff = 0;
            int sum = number1 + number2;

            for (int i = 1; i < n; i++)
            {
                number1 = int.Parse(Console.ReadLine());
                number2 = int.Parse(Console.ReadLine());
                int oldSum = sum;
                sum = number1 + number2;
                maxDiff = int.MinValue;
                int diff = Math.Max(sum, oldSum)-Math.Min(sum, oldSum);
                if (diff > maxDiff)
                {
                    maxDiff = diff;
                }                
            }
            if (maxDiff==0)
            {
                Console.WriteLine($"Yes, value={sum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
