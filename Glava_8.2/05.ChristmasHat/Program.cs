using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ChristmasHat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string('.', 2 * n - 1));
            Console.Write("/|\\");
            Console.Write(new string('.', 2 * n - 1));
            Console.WriteLine();
            Console.Write(new string('.', 2 * n - 1));
            Console.Write("\\|/");
            Console.Write(new string('.', 2 * n - 1));
            Console.WriteLine();

            for (int j = 2 * n; j >= 1; j--)
            {
                Console.Write(new string('.', j - 1));
                Console.Write("*");
                Console.Write(new string('-', 2 * n - j));
                Console.Write("*");
                Console.Write(new string('-', 2 * n - j));
                Console.Write("*");
                Console.Write(new string('.', j - 1));
                Console.WriteLine();
            }
            
            Console.WriteLine(new string('*', 4 * n + 1));
            for (int i = 1; i <= n; i++)
            {
                Console.Write("*.");
            }
            Console.Write("*");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(".*");
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', 4 * n + 1));
            Console.WriteLine();

        }
    }
}
