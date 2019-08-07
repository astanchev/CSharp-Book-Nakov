using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                sum += number % 10;
                number /= 10;
            } while (number > 0);
            Console.WriteLine($"Sum of digits: {sum}");
        }
    }
}
