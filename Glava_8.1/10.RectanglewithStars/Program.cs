using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.RectanglewithStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(new string('%', 2 * n));
            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                Console.Write("%");
                Console.Write(new string(' ', 2 * n - 2));
                Console.Write("%");
                Console.WriteLine();
            }
            Console.Write("%");
            Console.Write(new string(' ', (2 * n - 4) / 2));
            Console.Write("**");
            Console.Write(new string(' ', (2 * n - 4) / 2));
            Console.Write("%");
            Console.WriteLine();
            for (int i = 1; i <= (n - 1) / 2; i++)
            {
                Console.Write("%");
                Console.Write(new string(' ', 2 * n - 2));
                Console.Write("%");
                Console.WriteLine();
            }
            Console.WriteLine(new string('%', 2 * n));
        }
    }
}
