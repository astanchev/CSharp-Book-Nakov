using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = 2 * n;
            int z = n + 1;
            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            for (int i = k - 1; i > 0; i--)
            {
                k *= i;
            }
            for (int i = z - 1; i > 0; i--)
            {
                z *= i;
            }
            int rezult =  k / (n*z);
            Console.WriteLine(rezult);
        }
    }
}
