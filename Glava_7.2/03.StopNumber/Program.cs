using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());
            for (int i = m; i >= n; i--)
            {
                if (i%6==0)
                {
                    if (i==stopNumber)
                    {
                        break;
                    }
                    Console.Write($"{i} ");
                }

            }

        }
    }
}
