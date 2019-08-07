using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumsStep3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 1; i <= n; i++)
            {
                a = int.Parse(Console.ReadLine());
                if (i%3==1)
                {
                    sum1 += a;
                }
                else if (i % 3 == 2)
                {
                    sum2 += a;
                }
                else if (i % 3 == 0)
                {
                    sum3 += a;
                }
            }

            Console.WriteLine($"Sum1 = {sum1}");
            Console.WriteLine($"Sum2 = {sum2}");
            Console.WriteLine($"Sum3 = {sum3}");
        }
    }
}
