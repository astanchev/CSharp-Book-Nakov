using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            int countP4 = 0;
            int countP5 = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number<200)
                {
                    countP1++;
                }
                else if (number < 400)
                {
                    countP2++;
                }
                else if (number < 600)
                {
                    countP3++;
                }
                else if (number < 800)
                {
                    countP4++;
                }
                else if (number > 799)
                {
                    countP5++;
                }
            }
            Console.WriteLine($"{((countP1 * 100.0) / n):0.00}%");
            Console.WriteLine($"{((countP2 * 100.0) / n):0.00}%");
            Console.WriteLine($"{((countP3 * 100.0) / n):0.00}%");
            Console.WriteLine($"{((countP4 * 100.0) / n):0.00}%");
            Console.WriteLine($"{((countP5 * 100.0) / n):0.00}%");
        }
    }
}
