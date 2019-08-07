using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sums3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a + b == c)
            {
                Console.WriteLine($"{Math.Min(a, b)} + {Math.Max(a, b)} = {c}");
            }
            else if (a + c == b)
            {
                Console.WriteLine($"{Math.Min(a, c)} + {Math.Max(a, c)} = {b}");
            }
            else if (c + b == a)
            {
                Console.WriteLine($"{Math.Min(c, b)} + {Math.Max(c, b)} = {a}");
            }
            else
            {
                Console.WriteLine("No");
            }


        }
    }
}
