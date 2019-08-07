using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad09
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            double temp = 1.0;
            double sum = 1.0;
            for (double i = 1; i <= n; i++)
            {
                temp *= i / x;
                sum += temp;
            }
            Console.WriteLine($"{sum:f3}");
            Console.WriteLine();
            Console.WriteLine();

            double factoriel = 1.0;
            double power = 1.0;
            double suma = 1.0;

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
                power *= x;
                suma += factoriel / power;
            }
            Console.WriteLine($"{suma:f3}");
        }
    }
}
