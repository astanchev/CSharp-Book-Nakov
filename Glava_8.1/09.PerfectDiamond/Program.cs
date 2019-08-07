using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PerfectDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.Write("*");
                for (int j = 0; j < i-1; j++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
            for (int k = n-1; k >0; k--)
            {
                Console.Write(new string(' ', n - k));
                Console.Write("*");
                for (int m = 0; m < k - 1; m++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }
        }
    }
}
