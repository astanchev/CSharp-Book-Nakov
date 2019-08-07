using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Division
{
    class Division
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int countP1 = 0;
            int countP2 = 0;
            int countP3 = 0;
            
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    countP1++;
                }
                if (number % 3 == 0)
                {
                    countP2++;
                }
                if (number % 4 == 0)
                {
                    countP3++;
                }
                
            }
            Console.WriteLine($"{((countP1 * 100.0) / n):0.00}%");
            Console.WriteLine($"{((countP2 * 100.0) / n):0.00}%");
            Console.WriteLine($"{((countP3 * 100.0) / n):0.00}%");
            
        }
    }
}
