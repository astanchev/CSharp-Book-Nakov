using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BreakSum
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 3; j >= 1; j--)
                {
                    if (i+j==2)
                    {
                        return;
                    }
                    Console.WriteLine($"{i} {j}");
                }
            }
        }
    }
}
