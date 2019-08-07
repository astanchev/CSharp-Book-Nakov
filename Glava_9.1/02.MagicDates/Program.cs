using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MagicDates
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int dateweight = 0;
            bool printed = false;

            int d10 = 0;
            int d01 = 0;
            int m10 = 0;
            int m01 = 0;
            int y1000 = 0;
            int y0100 = 0;
            int y0010 = 0;
            int y0001 = 0;

            //DateTime currentDate = new DateTime(startYear, 1, 1);
            DateTime endDate = new DateTime(endYear, 12, 31);

            for (DateTime currentDate = new DateTime(startYear, 1, 1); currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                d10 = currentDate.Day / 10;
                d01 = currentDate.Day % 10;
                m10 = currentDate.Month / 10;
                m01 = currentDate.Month % 10;
                y1000 = currentDate.Year / 1000;
                y0100 = (currentDate.Year / 100) % 10;
                y0010 = (currentDate.Year / 10) % 10;
                y0001 = currentDate.Year % 10;

                dateweight = d10 * (d01 + m10 + m01 + y1000 + y0100 + y0010 + y0001) +
                    d01 * (m10 + m01 + y1000 + y0100 + y0010 + y0001) + m10 * (m01 + y1000 + y0100 + y0010 + y0001) +
                    m01 * (y1000 + y0100 + y0010 + y0001) + y1000 * (y0100 + y0010 + y0001) + y0100 * (y0010 + y0001) + y0010 * (y0001) ;

                if (dateweight == magicNumber)
                {
                    printed = true;
                    Console.WriteLine($"{currentDate.Day:00}-{currentDate.Month:00}-{currentDate.Year:00}");
                }
            }
            if (!printed)
            {
                Console.WriteLine("No");
            }
        }
    }
}
