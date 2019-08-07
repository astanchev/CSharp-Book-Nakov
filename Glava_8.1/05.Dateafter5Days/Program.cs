using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dateafter5Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            d += 5;

            switch (m)
            {
                case 2:
                    if (d > 28)
                    {
                        d -= 28;
                        m++;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (d > 30)
                    {
                        d -= 30;
                        m++;
                    }
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (d > 31)
                    {
                        d -= 31;
                        m++;
                    }
                    if (m > 12)
                    {
                        m = 1;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{d}.{m:00}");
        }
    }
}
