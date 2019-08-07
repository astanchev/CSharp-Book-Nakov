using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = n - 1; i > 0; i--)
            {
                n *= i;
            }
            while (n % 10 == 0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine(count);
            Console.WriteLine(n);
        }
    }
}
