using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumNumbers = 0.0;
            int maxNumber = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
                sumNumbers += number;
            }
            if (sumNumbers / 2 == maxNumber)
            {
                Console.WriteLine("Yes \nSum = {0}", maxNumber);
            }
            else
            {
                Console.WriteLine("No \nDiff = {0}", Math.Abs(2 * maxNumber - sumNumbers));
            }
        }
    }
}
