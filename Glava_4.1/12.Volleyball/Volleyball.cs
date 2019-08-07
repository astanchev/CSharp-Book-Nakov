using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine().ToLower();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int numberOfTravelWeekends = int.Parse(Console.ReadLine());

            int weekendsInSofia = 48 - numberOfTravelWeekends;
            double playInSofia = (3.0 * weekendsInSofia) / 4 + (2.0 * numberOfHolidays) / 3;
            double totalPlay = playInSofia + numberOfTravelWeekends;

            if (typeOfYear == "leap")
            {
                totalPlay = Math.Floor(totalPlay * 1.15);
            }
            else if (typeOfYear == "normal")
            {
                totalPlay = Math.Floor(totalPlay);
            }
            Console.WriteLine(totalPlay);


        }
    }
}
