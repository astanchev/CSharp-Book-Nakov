using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PointonSegment
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int point = int.Parse(Console.ReadLine());

            int close = Math.Min(Math.Abs(first - point), Math.Abs(second - point));

            if (point >= Math.Min(first, second) && point <= Math.Max(first, second))
            {
                Console.WriteLine("in");
                Console.WriteLine(close);
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(close);
            }
        }
    }
}
