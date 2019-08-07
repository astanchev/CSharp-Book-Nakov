using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            while (b!=0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine($"GCD = {a}");

        }
    }
}
