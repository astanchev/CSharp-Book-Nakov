using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrimeDeviderInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = n; i < m; i++)
            {
                bool prime = true;
                int devider = 2;
                int maxDevider = (int)Math.Sqrt(i);
                while (devider<=maxDevider)
                {
                    if (i%devider==0)
                    {
                        prime = false;
                        break;
                    }
                    devider++;
                }
                if (prime)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
        }
    }
}
