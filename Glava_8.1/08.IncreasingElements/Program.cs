using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.IncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int newA = 0;
            int oldA = 0;
            int counter = 0;
            int counterBest = 0;

            for (int i = 1; i <= n; i++)
            {
                newA = int.Parse(Console.ReadLine());
                if (newA > oldA)
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter>counterBest)
                {
                    counterBest = counter;
                }
                oldA = newA;
            }
            Console.WriteLine(counterBest);
        }
    }
}
