using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int halfRowsize = n - 2;
            for (int i = 1; i <= halfRowsize; i++)
            {
                if (i%2!=0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*',halfRowsize));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', halfRowsize));
                }
            }
            Console.WriteLine("{0} @ {0}", new string(' ', halfRowsize));
            for (int i = 1; i <= halfRowsize; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', halfRowsize));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', halfRowsize));
                }
            }
        }
    }
}
