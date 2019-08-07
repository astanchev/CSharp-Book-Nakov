using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            for (int i = n-1; i > 0; i--)
            {
                n *= i;
            }
            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }
            n /= k;
            Console.WriteLine(n);
        }
    }
}
